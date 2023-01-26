using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILbNetworkLoadBalancerAttachedTargetGroup), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroup")]
    public interface ILbNetworkLoadBalancerAttachedTargetGroup
    {
        /// <summary>healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#healthcheck LbNetworkLoadBalancer#healthcheck}
        /// </remarks>
        [JsiiProperty(name: "healthcheck", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheck\"},\"kind\":\"array\"}}]}}")]
        object Healthcheck
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#target_group_id LbNetworkLoadBalancer#target_group_id}.</summary>
        [JsiiProperty(name: "targetGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string TargetGroupId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbNetworkLoadBalancerAttachedTargetGroup), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroup")]
        internal sealed class _Proxy : DeputyBase, yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>healthcheck block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#healthcheck LbNetworkLoadBalancer#healthcheck}
            /// </remarks>
            [JsiiProperty(name: "healthcheck", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheck\"},\"kind\":\"array\"}}]}}")]
            public object Healthcheck
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#target_group_id LbNetworkLoadBalancer#target_group_id}.</summary>
            [JsiiProperty(name: "targetGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetGroupId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
