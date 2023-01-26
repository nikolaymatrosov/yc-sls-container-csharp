using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionScalingPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.functionScalingPolicy.FunctionScalingPolicyPolicy")]
    public class FunctionScalingPolicyPolicy : yandex.FunctionScalingPolicy.IFunctionScalingPolicyPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_scaling_policy#tag FunctionScalingPolicy#tag}.</summary>
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
        public string Tag
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_scaling_policy#zone_instances_limit FunctionScalingPolicy#zone_instances_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zoneInstancesLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ZoneInstancesLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_scaling_policy#zone_requests_limit FunctionScalingPolicy#zone_requests_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zoneRequestsLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ZoneRequestsLimit
        {
            get;
            set;
        }
    }
}
