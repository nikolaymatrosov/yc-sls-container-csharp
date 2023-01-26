using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler")]
    public class AlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler : yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#backend_group_id AlbLoadBalancer#backend_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backendGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BackendGroupId
        {
            get;
            set;
        }
    }
}
