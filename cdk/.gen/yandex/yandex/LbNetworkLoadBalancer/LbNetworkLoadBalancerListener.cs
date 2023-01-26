using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListener")]
    public class LbNetworkLoadBalancerListener : yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#name LbNetworkLoadBalancer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#port LbNetworkLoadBalancer#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>external_address_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#external_address_spec LbNetworkLoadBalancer#external_address_spec}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalAddressSpec", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerExternalAddressSpec\"}", isOptional: true)]
        public yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerExternalAddressSpec? ExternalAddressSpec
        {
            get;
            set;
        }

        /// <summary>internal_address_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#internal_address_spec LbNetworkLoadBalancer#internal_address_spec}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalAddressSpec", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerInternalAddressSpec\"}", isOptional: true)]
        public yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerInternalAddressSpec? InternalAddressSpec
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#protocol LbNetworkLoadBalancer#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#target_port LbNetworkLoadBalancer#target_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetPort
        {
            get;
            set;
        }
    }
}
