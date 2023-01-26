using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerTlsDefaultHandlerHttpHandler), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerHttpHandler")]
    public interface IAlbLoadBalancerListenerTlsDefaultHandlerHttpHandler
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#allow_http10 AlbLoadBalancer#allow_http10}.</summary>
        [JsiiProperty(name: "allowHttp10", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowHttp10
        {
            get
            {
                return null;
            }
        }

        /// <summary>http2_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http2_options AlbLoadBalancer#http2_options}
        /// </remarks>
        [JsiiProperty(name: "http2Options", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerHttpHandlerHttp2Options\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerHttpHandlerHttp2Options? Http2Options
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_router_id AlbLoadBalancer#http_router_id}.</summary>
        [JsiiProperty(name: "httpRouterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpRouterId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerTlsDefaultHandlerHttpHandler), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerHttpHandler")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerHttpHandler
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#allow_http10 AlbLoadBalancer#allow_http10}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowHttp10", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowHttp10
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http2_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http2_options AlbLoadBalancer#http2_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http2Options", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerHttpHandlerHttp2Options\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerHttpHandlerHttp2Options? Http2Options
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerHttpHandlerHttp2Options?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_router_id AlbLoadBalancer#http_router_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpRouterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpRouterId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
