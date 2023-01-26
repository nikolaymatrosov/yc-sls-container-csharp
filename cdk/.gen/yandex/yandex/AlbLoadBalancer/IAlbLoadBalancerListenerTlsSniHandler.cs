using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerTlsSniHandler), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandler")]
    public interface IAlbLoadBalancerListenerTlsSniHandler
    {
        /// <summary>handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#handler AlbLoadBalancer#handler}
        /// </remarks>
        [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandler\"}")]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandler Handler
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#name AlbLoadBalancer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#server_names AlbLoadBalancer#server_names}.</summary>
        [JsiiProperty(name: "serverNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ServerNames
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerTlsSniHandler), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandler")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandler
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>handler block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#handler AlbLoadBalancer#handler}
            /// </remarks>
            [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandler\"}")]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandler Handler
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandler>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#name AlbLoadBalancer#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#server_names AlbLoadBalancer#server_names}.</summary>
            [JsiiProperty(name: "serverNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ServerNames
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
