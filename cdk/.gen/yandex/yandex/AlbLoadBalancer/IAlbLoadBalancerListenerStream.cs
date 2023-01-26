using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerStream), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerStream")]
    public interface IAlbLoadBalancerListenerStream
    {
        /// <summary>handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#handler AlbLoadBalancer#handler}
        /// </remarks>
        [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerStreamHandler\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStreamHandler? Handler
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerStream), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerStream")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStream
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>handler block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#handler AlbLoadBalancer#handler}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerStreamHandler\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStreamHandler? Handler
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStreamHandler?>();
            }
        }
    }
}
