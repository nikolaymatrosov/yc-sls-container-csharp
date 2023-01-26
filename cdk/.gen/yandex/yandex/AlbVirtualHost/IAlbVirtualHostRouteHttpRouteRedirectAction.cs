using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteHttpRouteRedirectAction), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteRedirectAction")]
    public interface IAlbVirtualHostRouteHttpRouteRedirectAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#remove_query AlbVirtualHost#remove_query}.</summary>
        [JsiiProperty(name: "removeQuery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RemoveQuery
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_host AlbVirtualHost#replace_host}.</summary>
        [JsiiProperty(name: "replaceHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplaceHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_path AlbVirtualHost#replace_path}.</summary>
        [JsiiProperty(name: "replacePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplacePath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_port AlbVirtualHost#replace_port}.</summary>
        [JsiiProperty(name: "replacePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplacePort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_prefix AlbVirtualHost#replace_prefix}.</summary>
        [JsiiProperty(name: "replacePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplacePrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_scheme AlbVirtualHost#replace_scheme}.</summary>
        [JsiiProperty(name: "replaceScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplaceScheme
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#response_code AlbVirtualHost#response_code}.</summary>
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseCode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteHttpRouteRedirectAction), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteRedirectAction")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteRedirectAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#remove_query AlbVirtualHost#remove_query}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "removeQuery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RemoveQuery
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_host AlbVirtualHost#replace_host}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replaceHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplaceHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_path AlbVirtualHost#replace_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replacePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplacePath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_port AlbVirtualHost#replace_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replacePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplacePort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_prefix AlbVirtualHost#replace_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replacePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplacePrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_scheme AlbVirtualHost#replace_scheme}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replaceScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplaceScheme
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#response_code AlbVirtualHost#response_code}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseCode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
