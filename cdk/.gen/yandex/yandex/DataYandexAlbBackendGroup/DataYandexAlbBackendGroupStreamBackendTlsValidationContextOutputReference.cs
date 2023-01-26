using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendTlsValidationContextOutputReference), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendTlsValidationContextOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataYandexAlbBackendGroupStreamBackendTlsValidationContextOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataYandexAlbBackendGroupStreamBackendTlsValidationContextOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataYandexAlbBackendGroupStreamBackendTlsValidationContextOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexAlbBackendGroupStreamBackendTlsValidationContextOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTrustedCaBytes")]
        public virtual void ResetTrustedCaBytes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTrustedCaId")]
        public virtual void ResetTrustedCaId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustedCaBytesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrustedCaBytesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustedCaIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TrustedCaIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "trustedCaBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustedCaBytes
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "trustedCaId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TrustedCaId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendTlsValidationContext\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendTlsValidationContext? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendTlsValidationContext?>();
            set => SetInstanceProperty(value);
        }
    }
}
