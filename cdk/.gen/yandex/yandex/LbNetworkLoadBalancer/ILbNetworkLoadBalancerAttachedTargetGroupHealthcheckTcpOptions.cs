using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions")]
    public interface ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#port LbNetworkLoadBalancer#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions")]
        internal sealed class _Proxy : DeputyBase, yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#port LbNetworkLoadBalancer#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
