using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.computeInstance.ComputeInstanceResources")]
    public class ComputeInstanceResources : yandex.ComputeInstance.IComputeInstanceResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#cores ComputeInstance#cores}.</summary>
        [JsiiProperty(name: "cores", typeJson: "{\"primitive\":\"number\"}")]
        public double Cores
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#memory ComputeInstance#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        public double Memory
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#core_fraction ComputeInstance#core_fraction}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "coreFraction", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CoreFraction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#gpus ComputeInstance#gpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Gpus
        {
            get;
            set;
        }
    }
}
