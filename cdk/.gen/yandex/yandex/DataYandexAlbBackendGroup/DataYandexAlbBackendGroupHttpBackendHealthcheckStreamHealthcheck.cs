using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck")]
    public class DataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck : yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#receive DataYandexAlbBackendGroup#receive}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "receive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Receive
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#send DataYandexAlbBackendGroup#send}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "send", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Send
        {
            get;
            set;
        }
    }
}
