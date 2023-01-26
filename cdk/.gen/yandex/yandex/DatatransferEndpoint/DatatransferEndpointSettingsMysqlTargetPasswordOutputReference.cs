using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiClass(nativeType: typeof(yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlTargetPasswordOutputReference), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetPasswordOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatatransferEndpointSettingsMysqlTargetPasswordOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatatransferEndpointSettingsMysqlTargetPasswordOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatatransferEndpointSettingsMysqlTargetPasswordOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatatransferEndpointSettingsMysqlTargetPasswordOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRaw")]
        public virtual void ResetRaw()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "rawInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RawInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "raw", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Raw
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetPassword\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetPassword? InternalValue
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetPassword?>();
            set => SetInstanceProperty(value);
        }
    }
}
