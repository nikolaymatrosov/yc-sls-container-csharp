using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerEndpointAddress), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddress")]
    public interface IAlbLoadBalancerListenerEndpointAddress
    {
        /// <summary>external_ipv4_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#external_ipv4_address AlbLoadBalancer#external_ipv4_address}
        /// </remarks>
        [JsiiProperty(name: "externalIpv4Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv4Address\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv4Address? ExternalIpv4Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>external_ipv6_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#external_ipv6_address AlbLoadBalancer#external_ipv6_address}
        /// </remarks>
        [JsiiProperty(name: "externalIpv6Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv6Address\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address? ExternalIpv6Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>internal_ipv4_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#internal_ipv4_address AlbLoadBalancer#internal_ipv4_address}
        /// </remarks>
        [JsiiProperty(name: "internalIpv4Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressInternalIpv4Address\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressInternalIpv4Address? InternalIpv4Address
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerEndpointAddress), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddress")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddress
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>external_ipv4_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#external_ipv4_address AlbLoadBalancer#external_ipv4_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalIpv4Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv4Address\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv4Address? ExternalIpv4Address
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv4Address?>();
            }

            /// <summary>external_ipv6_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#external_ipv6_address AlbLoadBalancer#external_ipv6_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalIpv6Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv6Address\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address? ExternalIpv6Address
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address?>();
            }

            /// <summary>internal_ipv4_address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#internal_ipv4_address AlbLoadBalancer#internal_ipv4_address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "internalIpv4Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressInternalIpv4Address\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressInternalIpv4Address? InternalIpv4Address
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressInternalIpv4Address?>();
            }
        }
    }
}
