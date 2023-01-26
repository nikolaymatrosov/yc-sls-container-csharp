using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiByValue(fqn: "yandex.computeInstanceGroup.ComputeInstanceGroupApplicationLoadBalancer")]
    public class ComputeInstanceGroupApplicationLoadBalancer : yandex.ComputeInstanceGroup.IComputeInstanceGroupApplicationLoadBalancer
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_opening_traffic_duration ComputeInstanceGroup#max_opening_traffic_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxOpeningTrafficDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxOpeningTrafficDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#target_group_description ComputeInstanceGroup#target_group_description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetGroupDescription
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#target_group_labels ComputeInstanceGroup#target_group_labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TargetGroupLabels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#target_group_name ComputeInstanceGroup#target_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetGroupName
        {
            get;
            set;
        }
    }
}
