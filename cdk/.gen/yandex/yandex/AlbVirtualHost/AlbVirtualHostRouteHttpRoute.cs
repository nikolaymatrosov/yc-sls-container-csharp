using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRoute")]
    public class AlbVirtualHostRouteHttpRoute : yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute
    {
        /// <summary>direct_response_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#direct_response_action AlbVirtualHost#direct_response_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "directResponseAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteDirectResponseAction\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteDirectResponseAction? DirectResponseAction
        {
            get;
            set;
        }

        private object? _httpMatch;

        /// <summary>http_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_match AlbVirtualHost#http_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HttpMatch
        {
            get => _httpMatch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _httpMatch = value;
            }
        }

        /// <summary>http_route_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_route_action AlbVirtualHost#http_route_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpRouteAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteAction\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpRouteAction? HttpRouteAction
        {
            get;
            set;
        }

        /// <summary>redirect_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#redirect_action AlbVirtualHost#redirect_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "redirectAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteRedirectAction\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteRedirectAction? RedirectAction
        {
            get;
            set;
        }
    }
}
