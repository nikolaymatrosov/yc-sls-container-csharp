using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv6Address")]
    public interface IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#address AlbLoadBalancer#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Address
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddressExternalIpv6Address")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddressExternalIpv6Address
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#address AlbLoadBalancer#address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Address
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
