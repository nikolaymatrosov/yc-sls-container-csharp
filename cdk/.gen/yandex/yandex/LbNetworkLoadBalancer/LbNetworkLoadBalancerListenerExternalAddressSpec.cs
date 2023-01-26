using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    [JsiiByValue(fqn: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerExternalAddressSpec")]
    public class LbNetworkLoadBalancerListenerExternalAddressSpec : yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerExternalAddressSpec
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#address LbNetworkLoadBalancer#address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#ip_version LbNetworkLoadBalancer#ip_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpVersion
        {
            get;
            set;
        }
    }
}
