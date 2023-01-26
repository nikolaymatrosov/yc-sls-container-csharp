using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.albBackendGroup.AlbBackendGroupGrpcBackendTls")]
    public class AlbBackendGroupGrpcBackendTls : yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTls
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#sni AlbBackendGroup#sni}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sni", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sni
        {
            get;
            set;
        }

        /// <summary>validation_context block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#validation_context AlbBackendGroup#validation_context}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validationContext", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendTlsValidationContext\"}", isOptional: true)]
        public yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTlsValidationContext? ValidationContext
        {
            get;
            set;
        }
    }
}
