using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteGrpcRoute), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteGrpcRoute")]
    public interface IAlbVirtualHostRouteGrpcRoute
    {
        /// <summary>grpc_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_match AlbVirtualHost#grpc_match}
        /// </remarks>
        [JsiiProperty(name: "grpcMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GrpcMatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>grpc_route_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_route_action AlbVirtualHost#grpc_route_action}
        /// </remarks>
        [JsiiProperty(name: "grpcRouteAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcRouteAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcRouteAction? GrpcRouteAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>grpc_status_response_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_status_response_action AlbVirtualHost#grpc_status_response_action}
        /// </remarks>
        [JsiiProperty(name: "grpcStatusResponseAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction? GrpcStatusResponseAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteGrpcRoute), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteGrpcRoute")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_match AlbVirtualHost#grpc_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpcMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GrpcMatch
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>grpc_route_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_route_action AlbVirtualHost#grpc_route_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpcRouteAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcRouteAction\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcRouteAction? GrpcRouteAction
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcRouteAction?>();
            }

            /// <summary>grpc_status_response_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#grpc_status_response_action AlbVirtualHost#grpc_status_response_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpcStatusResponseAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction? GrpcStatusResponseAction
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction?>();
            }
        }
    }
}
