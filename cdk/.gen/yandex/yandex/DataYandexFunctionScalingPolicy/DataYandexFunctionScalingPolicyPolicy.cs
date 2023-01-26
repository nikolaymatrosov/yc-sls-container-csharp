using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexFunctionScalingPolicy
{
    [JsiiByValue(fqn: "yandex.dataYandexFunctionScalingPolicy.DataYandexFunctionScalingPolicyPolicy")]
    public class DataYandexFunctionScalingPolicyPolicy : yandex.DataYandexFunctionScalingPolicy.IDataYandexFunctionScalingPolicyPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/function_scaling_policy#zone_instances_limit DataYandexFunctionScalingPolicy#zone_instances_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zoneInstancesLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ZoneInstancesLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/function_scaling_policy#zone_requests_limit DataYandexFunctionScalingPolicy#zone_requests_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zoneRequestsLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ZoneRequestsLimit
        {
            get;
            set;
        }
    }
}
