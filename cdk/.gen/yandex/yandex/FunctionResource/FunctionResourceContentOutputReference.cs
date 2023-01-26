using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionResource
{
    [JsiiClass(nativeType: typeof(yandex.FunctionResource.FunctionResourceContentOutputReference), fullyQualifiedName: "yandex.functionResource.FunctionResourceContentOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FunctionResourceContentOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FunctionResourceContentOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionResourceContentOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionResourceContentOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "zipFilenameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZipFilenameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "zipFilename", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ZipFilename
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.functionResource.FunctionResourceContent\"}", isOptional: true)]
        public virtual yandex.FunctionResource.IFunctionResourceContent? InternalValue
        {
            get => GetInstanceProperty<yandex.FunctionResource.IFunctionResourceContent?>();
            set => SetInstanceProperty(value);
        }
    }
}
