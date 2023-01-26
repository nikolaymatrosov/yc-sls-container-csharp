using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.AlbLoadBalancer.AlbLoadBalancerListenerHttpOutputReference), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerHttpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbLoadBalancerListenerHttpOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbLoadBalancerListenerHttpOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbLoadBalancerListenerHttpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbLoadBalancerListenerHttpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHandler", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpHandler\"}}]")]
        public virtual void PutHandler(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpHandler @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpHandler)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirects", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpRedirects\"}}]")]
        public virtual void PutRedirects(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpRedirects @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpRedirects)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHandler")]
        public virtual void ResetHandler()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirects")]
        public virtual void ResetRedirects()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpHandlerOutputReference\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerHttpHandlerOutputReference Handler
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerHttpHandlerOutputReference>()!;
        }

        [JsiiProperty(name: "redirects", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpRedirectsOutputReference\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerHttpRedirectsOutputReference Redirects
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerHttpRedirectsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "handlerInput", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpHandler\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpHandler? HandlerInput
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpHandler?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectsInput", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpRedirects\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpRedirects? RedirectsInput
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpRedirects?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttp\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttp? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttp?>();
            set => SetInstanceProperty(value);
        }
    }
}
