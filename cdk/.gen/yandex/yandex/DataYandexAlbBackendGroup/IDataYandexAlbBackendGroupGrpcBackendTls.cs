using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IDataYandexAlbBackendGroupGrpcBackendTls), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTls")]
    public interface IDataYandexAlbBackendGroupGrpcBackendTls
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#sni DataYandexAlbBackendGroup#sni}.</summary>
        [JsiiProperty(name: "sni", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sni
        {
            get
            {
                return null;
            }
        }

        /// <summary>validation_context block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#validation_context DataYandexAlbBackendGroup#validation_context}
        /// </remarks>
        [JsiiProperty(name: "validationContext", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTlsValidationContext\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTlsValidationContext? ValidationContext
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexAlbBackendGroupGrpcBackendTls), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTls")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#sni DataYandexAlbBackendGroup#sni}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sni", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sni
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>validation_context block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#validation_context DataYandexAlbBackendGroup#validation_context}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validationContext", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTlsValidationContext\"}", isOptional: true)]
            public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTlsValidationContext? ValidationContext
            {
                get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTlsValidationContext?>();
            }
        }
    }
}
