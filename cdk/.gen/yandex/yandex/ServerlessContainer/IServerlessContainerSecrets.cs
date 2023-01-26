using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ServerlessContainer
{
    [JsiiInterface(nativeType: typeof(IServerlessContainerSecrets), fullyQualifiedName: "yandex.serverlessContainer.ServerlessContainerSecrets")]
    public interface IServerlessContainerSecrets
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#environment_variable ServerlessContainer#environment_variable}.</summary>
        [JsiiProperty(name: "environmentVariable", typeJson: "{\"primitive\":\"string\"}")]
        string EnvironmentVariable
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#id ServerlessContainer#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#key ServerlessContainer#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#version_id ServerlessContainer#version_id}.</summary>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        string VersionId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IServerlessContainerSecrets), fullyQualifiedName: "yandex.serverlessContainer.ServerlessContainerSecrets")]
        internal sealed class _Proxy : DeputyBase, yandex.ServerlessContainer.IServerlessContainerSecrets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#environment_variable ServerlessContainer#environment_variable}.</summary>
            [JsiiProperty(name: "environmentVariable", typeJson: "{\"primitive\":\"string\"}")]
            public string EnvironmentVariable
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#id ServerlessContainer#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#key ServerlessContainer#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/serverless_container#version_id ServerlessContainer#version_id}.</summary>
            [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
            public string VersionId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
