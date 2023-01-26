using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerOutputReference), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbLoadBalancerListenerTlsSniHandlerHandlerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbLoadBalancerListenerTlsSniHandlerHandlerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbLoadBalancerListenerTlsSniHandlerHandlerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbLoadBalancerListenerTlsSniHandlerHandlerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHttpHandler", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler\"}}]")]
        public virtual void PutHttpHandler(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStreamHandler", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler\"}}]")]
        public virtual void PutStreamHandler(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHttpHandler")]
        public virtual void ResetHttpHandler()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamHandler")]
        public virtual void ResetStreamHandler()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "httpHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerOutputReference\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerOutputReference HttpHandler
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerOutputReference>()!;
        }

        [JsiiProperty(name: "streamHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandlerOutputReference\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandlerOutputReference StreamHandler
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandlerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? CertificateIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpHandlerInput", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler? HttpHandlerInput
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamHandlerInput", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler? StreamHandlerInput
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler?>();
        }

        [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CertificateIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandler\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandler? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandler?>();
            set => SetInstanceProperty(value);
        }
    }
}
