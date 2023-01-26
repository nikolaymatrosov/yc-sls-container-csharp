using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.storageBucket.StorageBucketServerSideEncryptionConfiguration")]
    public class StorageBucketServerSideEncryptionConfiguration : yandex.StorageBucket.IStorageBucketServerSideEncryptionConfiguration
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#rule StorageBucket#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRule\"}")]
        public yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRule Rule
        {
            get;
            set;
        }
    }
}
