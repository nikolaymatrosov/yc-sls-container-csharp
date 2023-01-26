using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    [JsiiInterface(nativeType: typeof(IStorageBucketServerSideEncryptionConfigurationRule), fullyQualifiedName: "yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRule")]
    public interface IStorageBucketServerSideEncryptionConfigurationRule
    {
        /// <summary>apply_server_side_encryption_by_default block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#apply_server_side_encryption_by_default StorageBucket#apply_server_side_encryption_by_default}
        /// </remarks>
        [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}")]
        yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageBucketServerSideEncryptionConfigurationRule), fullyQualifiedName: "yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRule")]
        internal sealed class _Proxy : DeputyBase, yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>apply_server_side_encryption_by_default block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#apply_server_side_encryption_by_default StorageBucket#apply_server_side_encryption_by_default}
            /// </remarks>
            [JsiiProperty(name: "applyServerSideEncryptionByDefault", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault\"}")]
            public yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault ApplyServerSideEncryptionByDefault
            {
                get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault>()!;
            }
        }
    }
}
