using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexFunctionScalingPolicy
{
    [JsiiInterface(nativeType: typeof(IDataYandexFunctionScalingPolicyPolicy), fullyQualifiedName: "yandex.dataYandexFunctionScalingPolicy.DataYandexFunctionScalingPolicyPolicy")]
    public interface IDataYandexFunctionScalingPolicyPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/function_scaling_policy#zone_instances_limit DataYandexFunctionScalingPolicy#zone_instances_limit}.</summary>
        [JsiiProperty(name: "zoneInstancesLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ZoneInstancesLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/function_scaling_policy#zone_requests_limit DataYandexFunctionScalingPolicy#zone_requests_limit}.</summary>
        [JsiiProperty(name: "zoneRequestsLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ZoneRequestsLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexFunctionScalingPolicyPolicy), fullyQualifiedName: "yandex.dataYandexFunctionScalingPolicy.DataYandexFunctionScalingPolicyPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexFunctionScalingPolicy.IDataYandexFunctionScalingPolicyPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/function_scaling_policy#zone_instances_limit DataYandexFunctionScalingPolicy#zone_instances_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zoneInstancesLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ZoneInstancesLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/function_scaling_policy#zone_requests_limit DataYandexFunctionScalingPolicy#zone_requests_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zoneRequestsLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ZoneRequestsLimit
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
