using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListenerHttp")]
    public class AlbLoadBalancerListenerHttp : yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttp
    {
        /// <summary>handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#handler AlbLoadBalancer#handler}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpHandler\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpHandler? Handler
        {
            get;
            set;
        }

        /// <summary>redirects block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#redirects AlbLoadBalancer#redirects}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirects", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttpRedirects\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpRedirects? Redirects
        {
            get;
            set;
        }
    }
}
