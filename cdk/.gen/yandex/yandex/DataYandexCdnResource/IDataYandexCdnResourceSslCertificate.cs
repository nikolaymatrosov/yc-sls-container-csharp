using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexCdnResource
{
    [JsiiInterface(nativeType: typeof(IDataYandexCdnResourceSslCertificate), fullyQualifiedName: "yandex.dataYandexCdnResource.DataYandexCdnResourceSslCertificate")]
    public interface IDataYandexCdnResourceSslCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#type DataYandexCdnResource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#certificate_manager_id DataYandexCdnResource#certificate_manager_id}.</summary>
        [JsiiProperty(name: "certificateManagerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateManagerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexCdnResourceSslCertificate), fullyQualifiedName: "yandex.dataYandexCdnResource.DataYandexCdnResourceSslCertificate")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexCdnResource.IDataYandexCdnResourceSslCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#type DataYandexCdnResource#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#certificate_manager_id DataYandexCdnResource#certificate_manager_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateManagerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateManagerId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
