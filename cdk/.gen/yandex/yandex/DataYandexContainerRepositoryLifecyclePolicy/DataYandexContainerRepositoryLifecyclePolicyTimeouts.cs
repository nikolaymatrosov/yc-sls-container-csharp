using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexContainerRepositoryLifecyclePolicy
{
    [JsiiByValue(fqn: "yandex.dataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyTimeouts")]
    public class DataYandexContainerRepositoryLifecyclePolicyTimeouts : yandex.DataYandexContainerRepositoryLifecyclePolicy.IDataYandexContainerRepositoryLifecyclePolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/container_repository_lifecycle_policy#default DataYandexContainerRepositoryLifecyclePolicy#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}
