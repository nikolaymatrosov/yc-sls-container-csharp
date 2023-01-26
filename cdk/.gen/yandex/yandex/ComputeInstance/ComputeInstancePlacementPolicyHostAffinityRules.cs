using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    [JsiiByValue(fqn: "yandex.computeInstance.ComputeInstancePlacementPolicyHostAffinityRules")]
    public class ComputeInstancePlacementPolicyHostAffinityRules : yandex.ComputeInstance.IComputeInstancePlacementPolicyHostAffinityRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#key ComputeInstance#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#op ComputeInstance#op}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "op", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Op
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#values ComputeInstance#values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
