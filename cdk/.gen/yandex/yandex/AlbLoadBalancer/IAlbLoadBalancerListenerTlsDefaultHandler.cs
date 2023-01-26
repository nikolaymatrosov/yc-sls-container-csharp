using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerTlsDefaultHandler), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandler")]
    public interface IAlbLoadBalancerListenerTlsDefaultHandler
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#certificate_ids AlbLoadBalancer#certificate_ids}.</summary>
        [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CertificateIds
        {
            get;
        }

        /// <summary>http_handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_handler AlbLoadBalancer#http_handler}
        /// </remarks>
        [JsiiProperty(name: "httpHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerHttpHandler\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerHttpHandler? HttpHandler
        {
            get
            {
                return null;
            }
        }

        /// <summary>stream_handler block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#stream_handler AlbLoadBalancer#stream_handler}
        /// </remarks>
        [JsiiProperty(name: "streamHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerStreamHandler\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerStreamHandler? StreamHandler
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerTlsDefaultHandler), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandler")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandler
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#certificate_ids AlbLoadBalancer#certificate_ids}.</summary>
            [JsiiProperty(name: "certificateIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CertificateIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>http_handler block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_handler AlbLoadBalancer#http_handler}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerHttpHandler\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerHttpHandler? HttpHandler
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerHttpHandler?>();
            }

            /// <summary>stream_handler block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#stream_handler AlbLoadBalancer#stream_handler}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "streamHandler", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerStreamHandler\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerStreamHandler? StreamHandler
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerStreamHandler?>();
            }
        }
    }
}
