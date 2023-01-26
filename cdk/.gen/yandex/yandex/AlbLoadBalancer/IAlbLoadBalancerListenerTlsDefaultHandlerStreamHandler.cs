using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerListenerTlsDefaultHandlerStreamHandler), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerStreamHandler")]
    public interface IAlbLoadBalancerListenerTlsDefaultHandlerStreamHandler
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#backend_group_id AlbLoadBalancer#backend_group_id}.</summary>
        [JsiiProperty(name: "backendGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BackendGroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerListenerTlsDefaultHandlerStreamHandler), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerListenerTlsDefaultHandlerStreamHandler")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerListenerTlsDefaultHandlerStreamHandler
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#backend_group_id AlbLoadBalancer#backend_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backendGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BackendGroupId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
