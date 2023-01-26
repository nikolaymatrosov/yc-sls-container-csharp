using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListenerTls")]
    public class AlbLoadBalancerListenerTls : yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTls
    {
        /// <summary>default_handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#default_handler AlbLoadBalancer#default_handler}
        /// </remarks>
        [JsiiProperty(name: "defaultHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandler\"}")]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandler DefaultHandler
        {
            get;
            set;
        }

        private object? _sniHandler;

        /// <summary>sni_handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#sni_handler AlbLoadBalancer#sni_handler}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sniHandler", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandler\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SniHandler
        {
            get => _sniHandler;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandler[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandler).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _sniHandler = value;
            }
        }
    }
}
