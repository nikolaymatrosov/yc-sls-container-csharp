using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.storageBucket.StorageBucketHttps")]
    public class StorageBucketHttps : yandex.StorageBucket.IStorageBucketHttps
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#certificate_id StorageBucket#certificate_id}.</summary>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        public string CertificateId
        {
            get;
            set;
        }
    }
}
