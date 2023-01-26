using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    [JsiiInterface(nativeType: typeof(IStorageBucketLogging), fullyQualifiedName: "yandex.storageBucket.StorageBucketLogging")]
    public interface IStorageBucketLogging
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#target_bucket StorageBucket#target_bucket}.</summary>
        [JsiiProperty(name: "targetBucket", typeJson: "{\"primitive\":\"string\"}")]
        string TargetBucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#target_prefix StorageBucket#target_prefix}.</summary>
        [JsiiProperty(name: "targetPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageBucketLogging), fullyQualifiedName: "yandex.storageBucket.StorageBucketLogging")]
        internal sealed class _Proxy : DeputyBase, yandex.StorageBucket.IStorageBucketLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#target_bucket StorageBucket#target_bucket}.</summary>
            [JsiiProperty(name: "targetBucket", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetBucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#target_prefix StorageBucket#target_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
