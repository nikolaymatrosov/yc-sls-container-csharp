using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteGrpcRouteGrpcMatch), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatch")]
    public interface IAlbVirtualHostRouteGrpcRouteGrpcMatch
    {
        /// <summary>fqmn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#fqmn AlbVirtualHost#fqmn}
        /// </remarks>
        [JsiiProperty(name: "fqmn", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatchFqmn\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatchFqmn? Fqmn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteGrpcRouteGrpcMatch), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatch")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>fqmn block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#fqmn AlbVirtualHost#fqmn}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fqmn", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatchFqmn\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatchFqmn? Fqmn
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatchFqmn?>();
            }
        }
    }
}
