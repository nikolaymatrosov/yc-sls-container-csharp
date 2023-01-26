using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    [JsiiInterface(nativeType: typeof(IStorageBucketServerSideEncryptionConfiguration), fullyQualifiedName: "yandex.storageBucket.StorageBucketServerSideEncryptionConfiguration")]
    public interface IStorageBucketServerSideEncryptionConfiguration
    {
        /// <summary>rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#rule StorageBucket#rule}
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRule\"}")]
        yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRule Rule
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageBucketServerSideEncryptionConfiguration), fullyQualifiedName: "yandex.storageBucket.StorageBucketServerSideEncryptionConfiguration")]
        internal sealed class _Proxy : DeputyBase, yandex.StorageBucket.IStorageBucketServerSideEncryptionConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#rule StorageBucket#rule}
            /// </remarks>
            [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRule\"}")]
            public yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRule Rule
            {
                get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRule>()!;
            }
        }
    }
}
