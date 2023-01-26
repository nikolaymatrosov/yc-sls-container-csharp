using System;
using System.Collections.Generic;
using Constructs;
using external.DataExternal;
using external.Provider;
using HashiCorp.Cdktf;
using Providers.Null.Provider;
using Providers.Null.Resource;
using yandex.ContainerRegistry;
using yandex.IamServiceAccount;
using yandex.Provider;
using yandex.ResourcemanagerFolderIamMember;
using yandex.ServerlessContainer;
using Resource = Providers.Null.Resource.Resource;

namespace MyTerraformStack
{
    class MainStack : TerraformStack
    {
        public MainStack(Construct scope, string id) : base(scope, id)
        {
            var folderId = new TerraformVariable(this, "folderId", new TerraformVariableConfig()
            {
                Type = "string",
                Description = "Folder where to deploy the container."
            });
            var token = new TerraformVariable(this, "token", new TerraformVariableConfig()
            {
                Type = "string",
                Description = "IAM Token to deploy the stack",
            });
            new NullProvider(this, "null", new NullProviderConfig());
            new ExternalProvider(this, "ext", new ExternalProviderConfig());
            new YandexProvider(this, "yandex", new YandexProviderConfig
            {
                FolderId = folderId.StringValue,
                Token = token.StringValue,
            });

            var containerSA = new IamServiceAccount(this, "container-sa", new IamServiceAccountConfig()
            {
                Name = "container-sa",
            });

            new ResourcemanagerFolderIamMember(this, "containerImagePuller", new ResourcemanagerFolderIamMemberConfig
            {
                FolderId = folderId.StringValue,
                Member = $"serviceAccount:{containerSA.Id}",
                Role = "container-registry.images.puller",
                SleepAfter = 10,
                DependsOn = new ITerraformDependable[]
                {
                    containerSA
                },
            });

            var sourceCodeAsset = new TerraformAsset(this, "source-code", new TerraformAssetConfig()
            {
                Path = "../ServerlessContainerDemo/"
            });

            var gitSha = new DataExternal(this, "git_hash", new DataExternalConfig
            {
                Program = new string[]
                {
                    "git",
                    "log",
                    "--pretty={\"sha\":\"%H\"}",
                    "-1",
                    "HEAD"
                },
            });

            var cr = new ContainerRegistry(this, "cr", new ContainerRegistryConfig
            {
                Name = "sls-demo-dotnet",
            });

            var imageName = "cr.yandex/" + cr.Id + "/serverless-dotnet:" + gitSha.Result.Lookup("sha");

            var image = new Resource(this, "image", new ResourceConfig()
            {
                Provisioners = new[]
                {
                    new LocalExecProvisioner
                    {
                        Command = $"docker build -t {imageName} . && docker push {imageName}",
                        Type = "local-exec",
                        WorkingDir = sourceCodeAsset.Path
                    }
                },
                Triggers = new Dictionary<string, string>()
                {
                    ["gitSHA"] = gitSha.Result.Lookup("sha"),
                }
            });

            var container = new ServerlessContainer(this, "container", new ServerlessContainerConfig
            {
                Image = new ServerlessContainerImage
                {
                    Url = imageName,
                    Environment = null,
                    WorkDir = null
                },
                Memory = 256,
                Name = "serverless-dotnet",
                ServiceAccountId = containerSA.Id,
                DependsOn = new[] {image}
            });

            new TerraformOutput(this, "container-url", new TerraformOutputConfig()
            {
                Value = container.Url,
            });
        }
    }
}