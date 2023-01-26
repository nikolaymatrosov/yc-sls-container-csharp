using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataYandexComputeInstance.DataYandexComputeInstanceLocalDisk")]
    public class DataYandexComputeInstanceLocalDisk : yandex.DataYandexComputeInstance.IDataYandexComputeInstanceLocalDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#size_bytes DataYandexComputeInstance#size_bytes}.</summary>
        [JsiiProperty(name: "sizeBytes", typeJson: "{\"primitive\":\"number\"}")]
        public double SizeBytes
        {
            get;
            set;
        }
    }
}
