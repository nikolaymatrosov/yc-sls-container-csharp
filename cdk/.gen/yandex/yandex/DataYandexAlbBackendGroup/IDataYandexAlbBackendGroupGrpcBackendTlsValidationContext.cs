using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IDataYandexAlbBackendGroupGrpcBackendTlsValidationContext), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTlsValidationContext")]
    public interface IDataYandexAlbBackendGroupGrpcBackendTlsValidationContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#trusted_ca_bytes DataYandexAlbBackendGroup#trusted_ca_bytes}.</summary>
        [JsiiProperty(name: "trustedCaBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustedCaBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#trusted_ca_id DataYandexAlbBackendGroup#trusted_ca_id}.</summary>
        [JsiiProperty(name: "trustedCaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustedCaId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexAlbBackendGroupGrpcBackendTlsValidationContext), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTlsValidationContext")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTlsValidationContext
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#trusted_ca_bytes DataYandexAlbBackendGroup#trusted_ca_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedCaBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustedCaBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#trusted_ca_id DataYandexAlbBackendGroup#trusted_ca_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedCaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustedCaId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
