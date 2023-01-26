using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IAlbBackendGroupHttpBackendTls), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupHttpBackendTls")]
    public interface IAlbBackendGroupHttpBackendTls
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#sni AlbBackendGroup#sni}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#validation_context AlbBackendGroup#validation_context}
        /// </remarks>
        [JsiiProperty(name: "validationContext", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendTlsValidationContext\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendTlsValidationContext? ValidationContext
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbBackendGroupHttpBackendTls), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupHttpBackendTls")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#sni AlbBackendGroup#sni}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sni", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sni
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>validation_context block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#validation_context AlbBackendGroup#validation_context}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "validationContext", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendTlsValidationContext\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendTlsValidationContext? ValidationContext
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendTlsValidationContext?>();
            }
        }
    }
}
