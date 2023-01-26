using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexContainerRepositoryLifecyclePolicy
{
    [JsiiInterface(nativeType: typeof(IDataYandexContainerRepositoryLifecyclePolicyTimeouts), fullyQualifiedName: "yandex.dataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyTimeouts")]
    public interface IDataYandexContainerRepositoryLifecyclePolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/container_repository_lifecycle_policy#default DataYandexContainerRepositoryLifecyclePolicy#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexContainerRepositoryLifecyclePolicyTimeouts), fullyQualifiedName: "yandex.dataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexContainerRepositoryLifecyclePolicy.IDataYandexContainerRepositoryLifecyclePolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/container_repository_lifecycle_policy#default DataYandexContainerRepositoryLifecyclePolicy#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
