using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
    public class StorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault : yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#kms_master_key_id StorageBucket#kms_master_key_id}.</summary>
        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string KmsMasterKeyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#sse_algorithm StorageBucket#sse_algorithm}.</summary>
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string SseAlgorithm
        {
            get;
            set;
        }
    }
}
