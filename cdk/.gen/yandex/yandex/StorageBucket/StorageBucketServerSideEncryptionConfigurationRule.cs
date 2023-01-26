using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRule")]
    public class StorageBucketServerSideEncryptionConfigurationRule : yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRule
    {
        /// <summary>apply_server_side_encryption_by_default block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#apply_server_side_encryption_by_default StorageBucket#apply_server_side_encryption_by_default}
        /// </remarks>
        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}")]
        public yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault
        {
            get;
            set;
        }
    }
}
