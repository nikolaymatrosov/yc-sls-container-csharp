using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionResource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.functionResource.FunctionResourceContent")]
    public class FunctionResourceContent : yandex.FunctionResource.IFunctionResourceContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#zip_filename FunctionResource#zip_filename}.</summary>
        [JsiiProperty(name: "zipFilename", typeJson: "{\"primitive\":\"string\"}")]
        public string ZipFilename
        {
            get;
            set;
        }
    }
}
