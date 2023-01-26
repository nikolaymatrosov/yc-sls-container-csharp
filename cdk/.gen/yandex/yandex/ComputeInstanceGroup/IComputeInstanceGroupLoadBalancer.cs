using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceGroupLoadBalancer), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupLoadBalancer")]
    public interface IComputeInstanceGroupLoadBalancer
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_opening_traffic_duration ComputeInstanceGroup#max_opening_traffic_duration}.</summary>
        [JsiiProperty(name: "maxOpeningTrafficDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxOpeningTrafficDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#target_group_description ComputeInstanceGroup#target_group_description}.</summary>
        [JsiiProperty(name: "targetGroupDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetGroupDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#target_group_labels ComputeInstanceGroup#target_group_labels}.</summary>
        [JsiiProperty(name: "targetGroupLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TargetGroupLabels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#target_group_name ComputeInstanceGroup#target_group_name}.</summary>
        [JsiiProperty(name: "targetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetGroupName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceGroupLoadBalancer), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupLoadBalancer")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstanceGroup.IComputeInstanceGroupLoadBalancer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_opening_traffic_duration ComputeInstanceGroup#max_opening_traffic_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxOpeningTrafficDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxOpeningTrafficDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#target_group_description ComputeInstanceGroup#target_group_description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetGroupDescription
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#target_group_labels ComputeInstanceGroup#target_group_labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TargetGroupLabels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#target_group_name ComputeInstanceGroup#target_group_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetGroupName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
