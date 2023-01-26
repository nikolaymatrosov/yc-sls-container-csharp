using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRoute), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRoute")]
    public interface IAlbVirtualHostRoute
    {
        /// <summary>grpc_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_route AlbVirtualHost#grpc_route}
        /// </remarks>
        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute? GrpcRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_route AlbVirtualHost#http_route}
        /// </remarks>
        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRoute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute? HttpRoute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#name AlbVirtualHost#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>route_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#route_options AlbVirtualHost#route_options}
        /// </remarks>
        [JsiiProperty(name: "routeOptions", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptions? RouteOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRoute), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRoute")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_route AlbVirtualHost#grpc_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRoute\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute? GrpcRoute
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute?>();
            }

            /// <summary>http_route block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_route AlbVirtualHost#http_route}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRoute\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute? HttpRoute
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#name AlbVirtualHost#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>route_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#route_options AlbVirtualHost#route_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routeOptions", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptions\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptions? RouteOptions
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptions?>();
            }
        }
    }
}
