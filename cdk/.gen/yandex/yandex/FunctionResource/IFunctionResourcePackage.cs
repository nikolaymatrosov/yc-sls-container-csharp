using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionResource
{
    [JsiiInterface(nativeType: typeof(IFunctionResourcePackage), fullyQualifiedName: "yandex.functionResource.FunctionResourcePackage")]
    public interface IFunctionResourcePackage
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#bucket_name FunctionResource#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        string BucketName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#object_name FunctionResource#object_name}.</summary>
        [JsiiProperty(name: "objectName", typeJson: "{\"primitive\":\"string\"}")]
        string ObjectName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#sha_256 FunctionResource#sha_256}.</summary>
        [JsiiProperty(name: "sha256", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Sha256
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionResourcePackage), fullyQualifiedName: "yandex.functionResource.FunctionResourcePackage")]
        internal sealed class _Proxy : DeputyBase, yandex.FunctionResource.IFunctionResourcePackage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#bucket_name FunctionResource#bucket_name}.</summary>
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#object_name FunctionResource#object_name}.</summary>
            [JsiiProperty(name: "objectName", typeJson: "{\"primitive\":\"string\"}")]
            public string ObjectName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#sha_256 FunctionResource#sha_256}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sha256", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Sha256
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
