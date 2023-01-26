using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions")]
    public interface ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#port LbNetworkLoadBalancer#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#path LbNetworkLoadBalancer#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions")]
        internal sealed class _Proxy : DeputyBase, yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions
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

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#path LbNetworkLoadBalancer#path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
