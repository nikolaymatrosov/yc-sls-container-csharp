using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerAllocationPolicy), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerAllocationPolicy")]
    public interface IAlbLoadBalancerAllocationPolicy
    {
        /// <summary>location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#location AlbLoadBalancer#location}
        /// </remarks>
        [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerAllocationPolicyLocation\"},\"kind\":\"array\"}}]}}")]
        object Location
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerAllocationPolicy), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerAllocationPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerAllocationPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#location AlbLoadBalancer#location}
            /// </remarks>
            [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerAllocationPolicyLocation\"},\"kind\":\"array\"}}]}}")]
            public object Location
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
