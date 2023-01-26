using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteHttpRouteHttpMatch), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatch")]
    public interface IAlbVirtualHostRouteHttpRouteHttpMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_method AlbVirtualHost#http_method}.</summary>
        [JsiiProperty(name: "httpMethod", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HttpMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#path AlbVirtualHost#path}
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatchPath\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatchPath? Path
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteHttpRouteHttpMatch), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatch")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_method AlbVirtualHost#http_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpMethod", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HttpMethod
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>path block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#path AlbVirtualHost#path}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatchPath\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatchPath? Path
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatchPath?>();
            }
        }
    }
}
