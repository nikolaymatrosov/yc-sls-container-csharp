using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsOutputReference), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbLoadBalancerListenerTlsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbLoadBalancerListenerTlsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbLoadBalancerListenerTlsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbLoadBalancerListenerTlsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultHandler", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandler\"}}]")]
        public virtual void PutDefaultHandler(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandler @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandler)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSniHandler", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandler\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSniHandler(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandler[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandler).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandler).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSniHandler")]
        public virtual void ResetSniHandler()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "defaultHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerOutputReference\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerOutputReference DefaultHandler
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerOutputReference>()!;
        }

        [JsiiProperty(name: "sniHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerList\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerList SniHandler
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultHandlerInput", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandler\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandler? DefaultHandlerInput
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandler?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sniHandlerInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandler\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SniHandlerInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTls\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTls? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTls?>();
            set => SetInstanceProperty(value);
        }
    }
}
