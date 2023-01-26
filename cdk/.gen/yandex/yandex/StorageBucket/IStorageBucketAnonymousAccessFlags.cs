using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    [JsiiInterface(nativeType: typeof(IStorageBucketAnonymousAccessFlags), fullyQualifiedName: "yandex.storageBucket.StorageBucketAnonymousAccessFlags")]
    public interface IStorageBucketAnonymousAccessFlags
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#list StorageBucket#list}.</summary>
        [JsiiProperty(name: "list", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? List
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#read StorageBucket#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStorageBucketAnonymousAccessFlags), fullyQualifiedName: "yandex.storageBucket.StorageBucketAnonymousAccessFlags")]
        internal sealed class _Proxy : DeputyBase, yandex.StorageBucket.IStorageBucketAnonymousAccessFlags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#list StorageBucket#list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "list", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? List
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket#read StorageBucket#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Read
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
