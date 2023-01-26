using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ContainerRepositoryLifecyclePolicy
{
    [JsiiByValue(fqn: "yandex.containerRepositoryLifecyclePolicy.ContainerRepositoryLifecyclePolicyTimeouts")]
    public class ContainerRepositoryLifecyclePolicyTimeouts : yandex.ContainerRepositoryLifecyclePolicy.IContainerRepositoryLifecyclePolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#default ContainerRepositoryLifecyclePolicy#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}
