using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerHttp2Options), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerHttp2Options")]
    public interface IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerHttp2Options
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#max_concurrent_streams AlbLoadBalancer#max_concurrent_streams}.</summary>
        [JsiiProperty(name: "maxConcurrentStreams", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentStreams
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerHttp2Options), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerHttp2Options")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsSniHandlerHandlerHttpHandlerHttp2Options
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#max_concurrent_streams AlbLoadBalancer#max_concurrent_streams}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentStreams", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentStreams
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
