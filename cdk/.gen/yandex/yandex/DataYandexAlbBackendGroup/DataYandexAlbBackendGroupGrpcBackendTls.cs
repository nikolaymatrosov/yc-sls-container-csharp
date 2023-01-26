using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTls")]
    public class DataYandexAlbBackendGroupGrpcBackendTls : yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTls
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#sni DataYandexAlbBackendGroup#sni}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sni", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sni
        {
            get;
            set;
        }

        /// <summary>validation_context block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#validation_context DataYandexAlbBackendGroup#validation_context}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validationContext", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTlsValidationContext\"}", isOptional: true)]
        public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTlsValidationContext? ValidationContext
        {
            get;
            set;
        }
    }
}
