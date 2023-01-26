using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheck")]
    public class LbNetworkLoadBalancerAttachedTargetGroupHealthcheck : yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#name LbNetworkLoadBalancer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#healthy_threshold LbNetworkLoadBalancer#healthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthyThreshold
        {
            get;
            set;
        }

        /// <summary>http_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#http_options LbNetworkLoadBalancer#http_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpOptions", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions\"}", isOptional: true)]
        public yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions? HttpOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#interval LbNetworkLoadBalancer#interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Interval
        {
            get;
            set;
        }

        /// <summary>tcp_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#tcp_options LbNetworkLoadBalancer#tcp_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions\"}", isOptional: true)]
        public yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions? TcpOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#timeout LbNetworkLoadBalancer#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#unhealthy_threshold LbNetworkLoadBalancer#unhealthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnhealthyThreshold
        {
            get;
            set;
        }
    }
}
