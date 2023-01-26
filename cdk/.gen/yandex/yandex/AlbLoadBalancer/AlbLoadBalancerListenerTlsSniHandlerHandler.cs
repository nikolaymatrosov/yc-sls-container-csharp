using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandler")]
    public class AlbLoadBalancerListenerTlsSniHandlerHandler : yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandler
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#certificate_ids AlbLoadBalancer#certificate_ids}.</summary>
        [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CertificateIds
        {
            get;
            set;
        }

        /// <summary>http_handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_handler AlbLoadBalancer#http_handler}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandler? HttpHandler
        {
            get;
            set;
        }

        /// <summary>stream_handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#stream_handler AlbLoadBalancer#stream_handler}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "streamHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler\"}", isOptional: true)]
        public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerStreamHandler? StreamHandler
        {
            get;
            set;
        }
    }
}
