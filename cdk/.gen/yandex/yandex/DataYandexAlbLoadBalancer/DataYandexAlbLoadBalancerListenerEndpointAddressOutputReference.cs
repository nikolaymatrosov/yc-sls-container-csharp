using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressOutputReference), fullyQualifiedName: "yandex.dataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexAlbLoadBalancerListenerEndpointAddressOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexAlbLoadBalancerListenerEndpointAddressOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexAlbLoadBalancerListenerEndpointAddressOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexAlbLoadBalancerListenerEndpointAddressOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "externalIpv4Address", typeJson: "{\"fqn\":\"yandex.dataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressExternalIpv4AddressList\"}")]
        public virtual yandex.DataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressExternalIpv4AddressList ExternalIpv4Address
        {
            get => GetInstanceProperty<yandex.DataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressExternalIpv4AddressList>()!;
        }

        [JsiiProperty(name: "externalIpv6Address", typeJson: "{\"fqn\":\"yandex.dataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressExternalIpv6AddressList\"}")]
        public virtual yandex.DataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressExternalIpv6AddressList ExternalIpv6Address
        {
            get => GetInstanceProperty<yandex.DataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressExternalIpv6AddressList>()!;
        }

        [JsiiProperty(name: "internalIpv4Address", typeJson: "{\"fqn\":\"yandex.dataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressInternalIpv4AddressList\"}")]
        public virtual yandex.DataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressInternalIpv4AddressList InternalIpv4Address
        {
            get => GetInstanceProperty<yandex.DataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddressInternalIpv4AddressList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexAlbLoadBalancer.DataYandexAlbLoadBalancerListenerEndpointAddress\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbLoadBalancer.IDataYandexAlbLoadBalancerListenerEndpointAddress? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexAlbLoadBalancer.IDataYandexAlbLoadBalancerListenerEndpointAddress?>();
            set => SetInstanceProperty(value);
        }
    }
}
