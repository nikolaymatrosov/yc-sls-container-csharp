using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.computeInstance.ComputeInstanceLocalDisk")]
    public class ComputeInstanceLocalDisk : yandex.ComputeInstance.IComputeInstanceLocalDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#size_bytes ComputeInstance#size_bytes}.</summary>
        [JsiiProperty(name: "sizeBytes", typeJson: "{\"primitive\":\"number\"}")]
        public double SizeBytes
        {
            get;
            set;
        }
    }
}
