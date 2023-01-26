using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler")]
    public class AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler : yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler
    {
        private object? _allowHttp10;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#allow_http10 AlbLoadBalancer#allow_http10}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowHttp10", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowHttp10
        {
            get => _allowHttp10;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowHttp10 = value;
            }
        }

        /// <summary>http2_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http2_options AlbLoadBalancer#http2_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http2Options", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerHttp2Options\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerHttp2Options? Http2Options
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_router_id AlbLoadBalancer#http_router_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpRouterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpRouterId
        {
            get;
            set;
        }
    }
}
