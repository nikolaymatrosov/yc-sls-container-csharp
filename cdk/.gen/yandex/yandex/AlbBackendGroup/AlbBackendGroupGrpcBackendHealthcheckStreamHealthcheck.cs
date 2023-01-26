using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck")]
    public class AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck : yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#receive AlbBackendGroup#receive}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "receive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Receive
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#send AlbBackendGroup#send}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "send", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Send
        {
            get;
            set;
        }
    }
}
