using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListener")]
    public class AlbLoadBalancerListener : yandex.AlbLoadBalancer.IAlbLoadBalancerListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#name AlbLoadBalancer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _endpoint;

        /// <summary>endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#endpoint AlbLoadBalancer#endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Endpoint
        {
            get => _endpoint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpoint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpoint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _endpoint = value;
            }
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http AlbLoadBalancer#http}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttp\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttp? Http
        {
            get;
            set;
        }

        /// <summary>stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#stream AlbLoadBalancer#stream}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stream", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerStream\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStream? Stream
        {
            get;
            set;
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#tls AlbLoadBalancer#tls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTls\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTls? Tls
        {
            get;
            set;
        }
    }
}
