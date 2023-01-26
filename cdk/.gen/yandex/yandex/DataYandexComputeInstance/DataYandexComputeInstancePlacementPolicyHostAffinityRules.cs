using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstance
{
    [JsiiByValue(fqn: "yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyHostAffinityRules")]
    public class DataYandexComputeInstancePlacementPolicyHostAffinityRules : yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicyHostAffinityRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#key DataYandexComputeInstance#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#op DataYandexComputeInstance#op}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "op", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Op
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#values DataYandexComputeInstance#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
