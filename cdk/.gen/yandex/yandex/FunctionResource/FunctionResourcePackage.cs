using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionResource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.functionResource.FunctionResourcePackage")]
    public class FunctionResourcePackage : yandex.FunctionResource.IFunctionResourcePackage
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#bucket_name FunctionResource#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#object_name FunctionResource#object_name}.</summary>
        [JsiiProperty(name: "objectName", typeJson: "{\"primitive\":\"string\"}")]
        public string ObjectName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#sha_256 FunctionResource#sha_256}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sha256", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Sha256
        {
            get;
            set;
        }
    }
}
