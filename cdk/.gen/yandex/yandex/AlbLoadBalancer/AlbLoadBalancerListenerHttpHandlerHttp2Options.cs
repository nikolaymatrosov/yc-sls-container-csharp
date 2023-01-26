using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListenerHttpHandlerHttp2Options")]
    public class AlbLoadBalancerListenerHttpHandlerHttp2Options : yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpHandlerHttp2Options
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#max_concurrent_streams AlbLoadBalancer#max_concurrent_streams}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentStreams", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentStreams
        {
            get;
            set;
        }
    }
}
