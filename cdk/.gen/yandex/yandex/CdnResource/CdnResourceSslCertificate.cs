using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.CdnResource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.cdnResource.CdnResourceSslCertificate")]
    public class CdnResourceSslCertificate : yandex.CdnResource.ICdnResourceSslCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cdn_resource#type CdnResource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cdn_resource#certificate_manager_id CdnResource#certificate_manager_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateManagerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateManagerId
        {
            get;
            set;
        }
    }
}
