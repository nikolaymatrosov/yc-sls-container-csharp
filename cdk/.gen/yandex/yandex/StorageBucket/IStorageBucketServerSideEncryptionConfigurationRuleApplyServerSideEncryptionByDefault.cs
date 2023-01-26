using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    [JsiiInterface(nativeType: typeof(IStorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault), fullyQualifiedName: "yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
    public interface IStorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#kms_master_key_id StorageBucket#kms_master_key_id}.</summary>
        [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string KmsMasterKeyId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#sse_algorithm StorageBucket#sse_algorithm}.</summary>
        [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string SseAlgorithm
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault), fullyQualifiedName: "yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault")]
        internal sealed class _Proxy : DeputyBase, yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRuleApplyServerSideEncryptionByDefault
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#kms_master_key_id StorageBucket#kms_master_key_id}.</summary>
            [JsiiProperty(name: "kmsMasterKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string KmsMasterKeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#sse_algorithm StorageBucket#sse_algorithm}.</summary>
            [JsiiProperty(name: "sseAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string SseAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
