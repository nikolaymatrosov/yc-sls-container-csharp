using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRouteGrpcRoute")]
    public class AlbVirtualHostRouteGrpcRoute : yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute
    {
        private object? _grpcMatch;

        /// <summary>grpc_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_match AlbVirtualHost#grpc_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpcMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GrpcMatch
        {
            get => _grpcMatch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _grpcMatch = value;
            }
        }

        /// <summary>grpc_route_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_route_action AlbVirtualHost#grpc_route_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpcRouteAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcRouteAction\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcRouteAction? GrpcRouteAction
        {
            get;
            set;
        }

        /// <summary>grpc_status_response_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_status_response_action AlbVirtualHost#grpc_status_response_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpcStatusResponseAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction? GrpcStatusResponseAction
        {
            get;
            set;
        }
    }
}
