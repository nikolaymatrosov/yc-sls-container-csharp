using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.CdnResource
{
    [JsiiInterface(nativeType: typeof(ICdnResourceSslCertificate), fullyQualifiedName: "yandex.cdnResource.CdnResourceSslCertificate")]
    public interface ICdnResourceSslCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cdn_resource#type CdnResource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cdn_resource#certificate_manager_id CdnResource#certificate_manager_id}.</summary>
        [JsiiProperty(name: "certificateManagerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateManagerId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnResourceSslCertificate), fullyQualifiedName: "yandex.cdnResource.CdnResourceSslCertificate")]
        internal sealed class _Proxy : DeputyBase, yandex.CdnResource.ICdnResourceSslCertificate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cdn_resource#type CdnResource#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cdn_resource#certificate_manager_id CdnResource#certificate_manager_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateManagerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateManagerId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
