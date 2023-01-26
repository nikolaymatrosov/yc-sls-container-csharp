using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionScalingPolicy
{
    [JsiiInterface(nativeType: typeof(IFunctionScalingPolicyPolicy), fullyQualifiedName: "yandex.functionScalingPolicy.FunctionScalingPolicyPolicy")]
    public interface IFunctionScalingPolicyPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_scaling_policy#tag FunctionScalingPolicy#tag}.</summary>
        [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
        string Tag
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_scaling_policy#zone_instances_limit FunctionScalingPolicy#zone_instances_limit}.</summary>
        [JsiiProperty(name: "zoneInstancesLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ZoneInstancesLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_scaling_policy#zone_requests_limit FunctionScalingPolicy#zone_requests_limit}.</summary>
        [JsiiProperty(name: "zoneRequestsLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ZoneRequestsLimit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionScalingPolicyPolicy), fullyQualifiedName: "yandex.functionScalingPolicy.FunctionScalingPolicyPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.FunctionScalingPolicy.IFunctionScalingPolicyPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_scaling_policy#tag FunctionScalingPolicy#tag}.</summary>
            [JsiiProperty(name: "tag", typeJson: "{\"primitive\":\"string\"}")]
            public string Tag
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_scaling_policy#zone_instances_limit FunctionScalingPolicy#zone_instances_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zoneInstancesLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ZoneInstancesLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_scaling_policy#zone_requests_limit FunctionScalingPolicy#zone_requests_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zoneRequestsLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ZoneRequestsLimit
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
