using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.AlbLoadBalancer.AlbLoadBalancerListenerStreamOutputReference), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerStreamOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbLoadBalancerListenerStreamOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbLoadBalancerListenerStreamOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbLoadBalancerListenerStreamOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbLoadBalancerListenerStreamOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHandler", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerStreamHandler\"}}]")]
        public virtual void PutHandler(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStreamHandler @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStreamHandler)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHandler")]
        public virtual void ResetHandler()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerStreamHandlerOutputReference\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerStreamHandlerOutputReference Handler
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerStreamHandlerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "handlerInput", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerStreamHandler\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStreamHandler? HandlerInput
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStreamHandler?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerStream\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStream? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStream?>();
            set => SetInstanceProperty(value);
        }
    }
}
