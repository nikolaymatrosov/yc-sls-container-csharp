using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerHttpRedirects), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerHttpRedirects")]
    public interface IAlbLoadBalancerListenerHttpRedirects
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_to_https AlbLoadBalancer#http_to_https}.</summary>
        [JsiiProperty(name: "httpToHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpToHttps
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerHttpRedirects), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerHttpRedirects")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerHttpRedirects
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_to_https AlbLoadBalancer#http_to_https}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpToHttps", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? HttpToHttps
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
