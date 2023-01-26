using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionResource
{
    [JsiiInterface(nativeType: typeof(IFunctionResourceContent), fullyQualifiedName: "yandex.functionResource.FunctionResourceContent")]
    public interface IFunctionResourceContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#zip_filename FunctionResource#zip_filename}.</summary>
        [JsiiProperty(name: "zipFilename", typeJson: "{\"primitive\":\"string\"}")]
        string ZipFilename
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionResourceContent), fullyQualifiedName: "yandex.functionResource.FunctionResourceContent")]
        internal sealed class _Proxy : DeputyBase, yandex.FunctionResource.IFunctionResourceContent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function#zip_filename FunctionResource#zip_filename}.</summary>
            [JsiiProperty(name: "zipFilename", typeJson: "{\"primitive\":\"string\"}")]
            public string ZipFilename
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
