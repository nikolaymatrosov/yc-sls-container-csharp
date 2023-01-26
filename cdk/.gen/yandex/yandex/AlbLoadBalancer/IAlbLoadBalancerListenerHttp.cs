using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerHttp), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerHttp")]
    public interface IAlbLoadBalancerListenerHttp
    {
        /// <summary>handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#handler AlbLoadBalancer#handler}
        /// </remarks>
        [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpHandler\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpHandler? Handler
        {
            get
            {
                return null;
            }
        }

        /// <summary>redirects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#redirects AlbLoadBalancer#redirects}
        /// </remarks>
        [JsiiProperty(name: "redirects", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpRedirects\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpRedirects? Redirects
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerHttp), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerHttp")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>handler block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#handler AlbLoadBalancer#handler}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpHandler\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpHandler? Handler
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpHandler?>();
            }

            /// <summary>redirects block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#redirects AlbLoadBalancer#redirects}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirects", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpRedirects\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpRedirects? Redirects
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpRedirects?>();
            }
        }
    }
}
