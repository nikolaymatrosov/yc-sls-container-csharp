using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateResources")]
    public class ComputeInstanceGroupInstanceTemplateResources : yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#cores ComputeInstanceGroup#cores}.</summary>
        [JsiiProperty(name: "cores", typeJson: "{\"primitive\":\"number\"}")]
        public double Cores
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#memory ComputeInstanceGroup#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        public double Memory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#core_fraction ComputeInstanceGroup#core_fraction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreFraction", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoreFraction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#gpus ComputeInstanceGroup#gpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Gpus
        {
            get;
            set;
        }
    }
}
