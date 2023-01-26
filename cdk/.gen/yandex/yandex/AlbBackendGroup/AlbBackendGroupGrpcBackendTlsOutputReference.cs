using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendTlsOutputReference), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupGrpcBackendTlsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbBackendGroupGrpcBackendTlsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbBackendGroupGrpcBackendTlsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbBackendGroupGrpcBackendTlsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbBackendGroupGrpcBackendTlsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putValidationContext", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendTlsValidationContext\"}}]")]
        public virtual void PutValidationContext(yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTlsValidationContext @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTlsValidationContext)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSni")]
        public virtual void ResetSni()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidationContext")]
        public virtual void ResetValidationContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "validationContext", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendTlsValidationContextOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendTlsValidationContextOutputReference ValidationContext
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendTlsValidationContextOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sniInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SniInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validationContextInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendTlsValidationContext\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTlsValidationContext? ValidationContextInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTlsValidationContext?>();
        }

        [JsiiProperty(name: "sni", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sni
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendTls\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTls? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTls?>();
            set => SetInstanceProperty(value);
        }
    }
}
