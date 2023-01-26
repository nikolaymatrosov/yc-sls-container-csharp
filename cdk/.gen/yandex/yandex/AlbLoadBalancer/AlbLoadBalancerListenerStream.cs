using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListenerStream")]
    public class AlbLoadBalancerListenerStream : yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStream
    {
        /// <summary>handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#handler AlbLoadBalancer#handler}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "handler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerStreamHandler\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStreamHandler? Handler
        {
            get;
            set;
        }
    }
}
