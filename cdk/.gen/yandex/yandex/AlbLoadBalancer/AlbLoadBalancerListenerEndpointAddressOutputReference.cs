using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.AlbLoadBalancer.AlbLoadBalancerListenerEndpointAddressOutputReference), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AlbLoadBalancerListenerEndpointAddressOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AlbLoadBalancerListenerEndpointAddressOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AlbLoadBalancerListenerEndpointAddressOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbLoadBalancerListenerEndpointAddressOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExternalIpv4Address", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv4Address\"}}]")]
        public virtual void PutExternalIpv4Address(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv4Address @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv4Address)}, new object[]{@value});
        }

        [JsiiMethod(name: "putExternalIpv6Address", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv6Address\"}}]")]
        public virtual void PutExternalIpv6Address(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInternalIpv4Address", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressInternalIpv4Address\"}}]")]
        public virtual void PutInternalIpv4Address(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressInternalIpv4Address @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressInternalIpv4Address)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExternalIpv4Address")]
        public virtual void ResetExternalIpv4Address()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalIpv6Address")]
        public virtual void ResetExternalIpv6Address()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInternalIpv4Address")]
        public virtual void ResetInternalIpv4Address()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "externalIpv4Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv4AddressOutputReference\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv4AddressOutputReference ExternalIpv4Address
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv4AddressOutputReference>()!;
        }

        [JsiiProperty(name: "externalIpv6Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv6AddressOutputReference\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv6AddressOutputReference ExternalIpv6Address
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv6AddressOutputReference>()!;
        }

        [JsiiProperty(name: "internalIpv4Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressInternalIpv4AddressOutputReference\"}")]
        public virtual yandex.AlbLoadBalancer.AlbLoadBalancerListenerEndpointAddressInternalIpv4AddressOutputReference InternalIpv4Address
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.AlbLoadBalancerListenerEndpointAddressInternalIpv4AddressOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalIpv4AddressInput", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv4Address\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv4Address? ExternalIpv4AddressInput
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv4Address?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalIpv6AddressInput", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv6Address\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address? ExternalIpv6AddressInput
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalIpv4AddressInput", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressInternalIpv4Address\"}", isOptional: true)]
        public virtual yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressInternalIpv4Address? InternalIpv4AddressInput
        {
            get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressInternalIpv4Address?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddress\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddress cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddress).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
