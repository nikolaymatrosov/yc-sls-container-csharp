using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckOutputReference), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetReceive")]
        public virtual void ResetReceive()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSend")]
        public virtual void ResetSend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "receiveInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReceiveInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sendInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SendInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "receive", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Receive
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "send", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Send
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck?>();
            set => SetInstanceProperty(value);
        }
    }
}
