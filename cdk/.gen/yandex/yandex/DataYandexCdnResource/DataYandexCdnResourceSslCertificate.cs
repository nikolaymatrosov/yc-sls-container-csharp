using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexCdnResource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataYandexCdnResource.DataYandexCdnResourceSslCertificate")]
    public class DataYandexCdnResourceSslCertificate : yandex.DataYandexCdnResource.IDataYandexCdnResourceSslCertificate
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#type DataYandexCdnResource#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/cdn_resource#certificate_manager_id DataYandexCdnResource#certificate_manager_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateManagerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateManagerId
        {
            get;
            set;
        }
    }
}
