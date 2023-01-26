using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListenerHttpRedirects")]
    public class AlbLoadBalancerListenerHttpRedirects : yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpRedirects
    {
        private object? _httpToHttps;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_to_https AlbLoadBalancer#http_to_https}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpToHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? HttpToHttps
        {
            get => _httpToHttps;
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
                _httpToHttps = value;
            }
        }
    }
}
