using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerTls), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTls")]
    public interface IAlbLoadBalancerListenerTls
    {
        /// <summary>default_handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#default_handler AlbLoadBalancer#default_handler}
        /// </remarks>
        [JsiiProperty(name: "defaultHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandler\"}")]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandler DefaultHandler
        {
            get;
        }

        /// <summary>sni_handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#sni_handler AlbLoadBalancer#sni_handler}
        /// </remarks>
        [JsiiProperty(name: "sniHandler", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandler\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SniHandler
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerTls), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTls")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTls
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>default_handler block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#default_handler AlbLoadBalancer#default_handler}
            /// </remarks>
            [JsiiProperty(name: "defaultHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandler\"}")]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandler DefaultHandler
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandler>()!;
            }

            /// <summary>sni_handler block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#sni_handler AlbLoadBalancer#sni_handler}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sniHandler", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandler\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? SniHandler
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
