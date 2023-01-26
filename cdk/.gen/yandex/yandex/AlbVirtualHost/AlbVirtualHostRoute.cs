using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRoute")]
    public class AlbVirtualHostRoute : yandex.AlbVirtualHost.IAlbVirtualHostRoute
    {
        /// <summary>grpc_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_route AlbVirtualHost#grpc_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRoute\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute? GrpcRoute
        {
            get;
            set;
        }

        /// <summary>http_route block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_route AlbVirtualHost#http_route}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRoute\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute? HttpRoute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#name AlbVirtualHost#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>route_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#route_options AlbVirtualHost#route_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "routeOptions", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptions\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptions? RouteOptions
        {
            get;
            set;
        }
    }
}
