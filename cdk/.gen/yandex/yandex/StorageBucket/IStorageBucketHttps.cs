using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    [JsiiInterface(nativeType: typeof(IStorageBucketHttps), fullyQualifiedName: "yandex.storageBucket.StorageBucketHttps")]
    public interface IStorageBucketHttps
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#certificate_id StorageBucket#certificate_id}.</summary>
        [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
        string CertificateId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageBucketHttps), fullyQualifiedName: "yandex.storageBucket.StorageBucketHttps")]
        internal sealed class _Proxy : DeputyBase, yandex.StorageBucket.IStorageBucketHttps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#certificate_id StorageBucket#certificate_id}.</summary>
            [JsiiProperty(name: "certificateId", typeJson: "{\"primitive\":\"string\"}")]
            public string CertificateId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
