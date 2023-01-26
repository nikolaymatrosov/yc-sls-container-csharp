using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroup")]
    public class LbNetworkLoadBalancerAttachedTargetGroup : yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroup
    {
        private object _healthcheck;

        /// <summary>healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#healthcheck LbNetworkLoadBalancer#healthcheck}
        /// </remarks>
        [JsiiProperty(name: "healthcheck", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheck\"},\"kind\":\"array\"}}]}}")]
        public object Healthcheck
        {
            get => _healthcheck;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheck[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheck).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheck).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _healthcheck = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#target_group_id LbNetworkLoadBalancer#target_group_id}.</summary>
        [JsiiProperty(name: "targetGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetGroupId
        {
            get;
            set;
        }
    }
}
