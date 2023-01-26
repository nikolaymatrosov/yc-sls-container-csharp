using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.computeInstanceGroup.ComputeInstanceGroupDeployPolicy")]
    public class ComputeInstanceGroupDeployPolicy : yandex.ComputeInstanceGroup.IComputeInstanceGroupDeployPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_expansion ComputeInstanceGroup#max_expansion}.</summary>
        [JsiiProperty(name: "maxExpansion", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxExpansion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_unavailable ComputeInstanceGroup#max_unavailable}.</summary>
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxUnavailable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_creating ComputeInstanceGroup#max_creating}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCreating", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxCreating
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_deleting ComputeInstanceGroup#max_deleting}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxDeleting", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxDeleting
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#startup_duration ComputeInstanceGroup#startup_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startupDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartupDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#strategy ComputeInstanceGroup#strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Strategy
        {
            get;
            set;
        }
    }
}
