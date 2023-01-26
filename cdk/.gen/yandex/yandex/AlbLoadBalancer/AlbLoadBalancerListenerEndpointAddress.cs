using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddress")]
    public class AlbLoadBalancerListenerEndpointAddress : yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddress
    {
        /// <summary>external_ipv4_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#external_ipv4_address AlbLoadBalancer#external_ipv4_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalIpv4Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv4Address\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv4Address? ExternalIpv4Address
        {
            get;
            set;
        }

        /// <summary>external_ipv6_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#external_ipv6_address AlbLoadBalancer#external_ipv6_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalIpv6Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv6Address\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address? ExternalIpv6Address
        {
            get;
            set;
        }

        /// <summary>internal_ipv4_address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#internal_ipv4_address AlbLoadBalancer#internal_ipv4_address}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalIpv4Address", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressInternalIpv4Address\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressInternalIpv4Address? InternalIpv4Address
        {
            get;
            set;
        }
    }
}
