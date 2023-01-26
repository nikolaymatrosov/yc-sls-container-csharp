using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ServerlessContainer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.serverlessContainer.ServerlessContainerSecrets")]
    public class ServerlessContainerSecrets : yandex.ServerlessContainer.IServerlessContainerSecrets
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#environment_variable ServerlessContainer#environment_variable}.</summary>
        [JsiiProperty(name: "environmentVariable", typeJson: "{\"primitive\":\"string\"}")]
        public string EnvironmentVariable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#id ServerlessContainer#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#key ServerlessContainer#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#version_id ServerlessContainer#version_id}.</summary>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public string VersionId
        {
            get;
            set;
        }
    }
}
