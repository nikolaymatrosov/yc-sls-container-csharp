using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteRedirectAction")]
    public class AlbVirtualHostRouteHttpRouteRedirectAction : yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteRedirectAction
    {
        private object? _removeQuery;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#remove_query AlbVirtualHost#remove_query}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "removeQuery", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? RemoveQuery
        {
            get => _removeQuery;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _removeQuery = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_host AlbVirtualHost#replace_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replaceHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplaceHost
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_path AlbVirtualHost#replace_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replacePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplacePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_port AlbVirtualHost#replace_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replacePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReplacePort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_prefix AlbVirtualHost#replace_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replacePrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplacePrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#replace_scheme AlbVirtualHost#replace_scheme}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replaceScheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplaceScheme
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#response_code AlbVirtualHost#response_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseCode
        {
            get;
            set;
        }
    }
}
