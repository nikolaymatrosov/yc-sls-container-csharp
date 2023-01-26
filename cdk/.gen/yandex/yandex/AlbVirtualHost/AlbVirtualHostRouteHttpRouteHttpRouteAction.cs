using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteAction")]
    public class AlbVirtualHostRouteHttpRouteHttpRouteAction : yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpRouteAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#backend_group_id AlbVirtualHost#backend_group_id}.</summary>
        [JsiiProperty(name: "backendGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string BackendGroupId
        {
            get;
            set;
        }

        private object? _autoHostRewrite;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#auto_host_rewrite AlbVirtualHost#auto_host_rewrite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoHostRewrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoHostRewrite
        {
            get => _autoHostRewrite;
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
                _autoHostRewrite = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#host_rewrite AlbVirtualHost#host_rewrite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostRewrite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostRewrite
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#idle_timeout AlbVirtualHost#idle_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IdleTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#prefix_rewrite AlbVirtualHost#prefix_rewrite}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefixRewrite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrefixRewrite
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#timeout AlbVirtualHost#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#upgrade_types AlbVirtualHost#upgrade_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "upgradeTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? UpgradeTypes
        {
            get;
            set;
        }
    }
}
