using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IAlbBackendGroupGrpcBackendTlsValidationContext), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupGrpcBackendTlsValidationContext")]
    public interface IAlbBackendGroupGrpcBackendTlsValidationContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#trusted_ca_bytes AlbBackendGroup#trusted_ca_bytes}.</summary>
        [JsiiProperty(name: "trustedCaBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustedCaBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#trusted_ca_id AlbBackendGroup#trusted_ca_id}.</summary>
        [JsiiProperty(name: "trustedCaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustedCaId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbBackendGroupGrpcBackendTlsValidationContext), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupGrpcBackendTlsValidationContext")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTlsValidationContext
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#trusted_ca_bytes AlbBackendGroup#trusted_ca_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedCaBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustedCaBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#trusted_ca_id AlbBackendGroup#trusted_ca_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedCaId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustedCaId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
