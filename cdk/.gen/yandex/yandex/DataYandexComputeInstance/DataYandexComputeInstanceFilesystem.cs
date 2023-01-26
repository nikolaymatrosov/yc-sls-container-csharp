using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstance
{
    [JsiiByValue(fqn: "yandex.dataYandexComputeInstance.DataYandexComputeInstanceFilesystem")]
    public class DataYandexComputeInstanceFilesystem : yandex.DataYandexComputeInstance.IDataYandexComputeInstanceFilesystem
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#mode DataYandexComputeInstance#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }
    }
}
