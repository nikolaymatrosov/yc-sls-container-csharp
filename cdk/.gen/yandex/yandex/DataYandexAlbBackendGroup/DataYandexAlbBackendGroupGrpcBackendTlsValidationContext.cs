using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTlsValidationContext")]
    public class DataYandexAlbBackendGroupGrpcBackendTlsValidationContext : yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTlsValidationContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#trusted_ca_bytes DataYandexAlbBackendGroup#trusted_ca_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedCaBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustedCaBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#trusted_ca_id DataYandexAlbBackendGroup#trusted_ca_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedCaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustedCaId
        {
            get;
            set;
        }
    }
}
