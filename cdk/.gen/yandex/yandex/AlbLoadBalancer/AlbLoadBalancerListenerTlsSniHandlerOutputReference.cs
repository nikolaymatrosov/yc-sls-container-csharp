using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerOutputReference), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AlbLoadBalancerListenerTlsSniHandlerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AlbLoadBalancerListenerTlsSniHandlerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbLoadBalancerListenerTlsSniHandlerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbLoadBalancerListenerTlsSniHandlerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHandler", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandler\"}}]")]
        public virtual void PutHandler(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandler @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandler)}, new object[]{@value});
        }

        [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerOutputReference\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerOutputReference Handler
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "handlerInput", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandler\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandler? HandlerInput
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandler?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ServerNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serverNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ServerNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandler\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandler cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandler).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
