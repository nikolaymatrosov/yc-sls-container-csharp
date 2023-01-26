using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ContainerRepositoryLifecyclePolicy
{
    [JsiiInterface(nativeType: typeof(IContainerRepositoryLifecyclePolicyTimeouts), fullyQualifiedName: "yandex.containerRepositoryLifecyclePolicy.ContainerRepositoryLifecyclePolicyTimeouts")]
    public interface IContainerRepositoryLifecyclePolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#default ContainerRepositoryLifecyclePolicy#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRepositoryLifecyclePolicyTimeouts), fullyQualifiedName: "yandex.containerRepositoryLifecyclePolicy.ContainerRepositoryLifecyclePolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, yandex.ContainerRepositoryLifecyclePolicy.IContainerRepositoryLifecyclePolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#default ContainerRepositoryLifecyclePolicy#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
