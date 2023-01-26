using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteHttpRoute), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRoute")]
    public interface IAlbVirtualHostRouteHttpRoute
    {
        /// <summary>direct_response_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#direct_response_action AlbVirtualHost#direct_response_action}
        /// </remarks>
        [JsiiProperty(name: "directResponseAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteDirectResponseAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteDirectResponseAction? DirectResponseAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_match AlbVirtualHost#http_match}
        /// </remarks>
        [JsiiProperty(name: "httpMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HttpMatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_route_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_route_action AlbVirtualHost#http_route_action}
        /// </remarks>
        [JsiiProperty(name: "httpRouteAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpRouteAction? HttpRouteAction
        {
            get
            {
                return null;
            }
        }

        /// <summary>redirect_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#redirect_action AlbVirtualHost#redirect_action}
        /// </remarks>
        [JsiiProperty(name: "redirectAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteRedirectAction\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteRedirectAction? RedirectAction
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteHttpRoute), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRoute")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>direct_response_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#direct_response_action AlbVirtualHost#direct_response_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "directResponseAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteDirectResponseAction\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteDirectResponseAction? DirectResponseAction
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteDirectResponseAction?>();
            }

            /// <summary>http_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_match AlbVirtualHost#http_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HttpMatch
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>http_route_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_route_action AlbVirtualHost#http_route_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRouteAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteAction\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpRouteAction? HttpRouteAction
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpRouteAction?>();
            }

            /// <summary>redirect_action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#redirect_action AlbVirtualHost#redirect_action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirectAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteRedirectAction\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteRedirectAction? RedirectAction
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteRedirectAction?>();
            }
        }
    }
}
