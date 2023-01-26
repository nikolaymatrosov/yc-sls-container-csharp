using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListener), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListener")]
    public interface IAlbLoadBalancerListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#name AlbLoadBalancer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#endpoint AlbLoadBalancer#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Endpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>http block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http AlbLoadBalancer#http}
        /// </remarks>
        [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttp? Http
        {
            get
            {
                return null;
            }
        }

        /// <summary>stream block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#stream AlbLoadBalancer#stream}
        /// </remarks>
        [JsiiProperty(name: "stream", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerStream\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStream? Stream
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#tls AlbLoadBalancer#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTls? Tls
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListener), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListener")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#name AlbLoadBalancer#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#endpoint AlbLoadBalancer#endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Endpoint
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http AlbLoadBalancer#http}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "http", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerHttp\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttp? Http
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttp?>();
            }

            /// <summary>stream block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#stream AlbLoadBalancer#stream}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stream", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerStream\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStream? Stream
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerStream?>();
            }

            /// <summary>tls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#tls AlbLoadBalancer#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerTls\"}", isOptional: true)]
            public yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTls? Tls
            {
                get => GetInstanceProperty<yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTls?>();
            }
        }
    }
}
