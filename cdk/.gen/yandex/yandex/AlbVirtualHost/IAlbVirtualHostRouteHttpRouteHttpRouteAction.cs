using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteHttpRouteHttpRouteAction), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteAction")]
    public interface IAlbVirtualHostRouteHttpRouteHttpRouteAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#backend_group_id AlbVirtualHost#backend_group_id}.</summary>
        [JsiiProperty(name: "backendGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string BackendGroupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#auto_host_rewrite AlbVirtualHost#auto_host_rewrite}.</summary>
        [JsiiProperty(name: "autoHostRewrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoHostRewrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#host_rewrite AlbVirtualHost#host_rewrite}.</summary>
        [JsiiProperty(name: "hostRewrite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HostRewrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#idle_timeout AlbVirtualHost#idle_timeout}.</summary>
        [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IdleTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#prefix_rewrite AlbVirtualHost#prefix_rewrite}.</summary>
        [JsiiProperty(name: "prefixRewrite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrefixRewrite
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#timeout AlbVirtualHost#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#upgrade_types AlbVirtualHost#upgrade_types}.</summary>
        [JsiiProperty(name: "upgradeTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? UpgradeTypes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteHttpRouteHttpRouteAction), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteAction")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpRouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#backend_group_id AlbVirtualHost#backend_group_id}.</summary>
            [JsiiProperty(name: "backendGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string BackendGroupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#auto_host_rewrite AlbVirtualHost#auto_host_rewrite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoHostRewrite", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoHostRewrite
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#host_rewrite AlbVirtualHost#host_rewrite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostRewrite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HostRewrite
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#idle_timeout AlbVirtualHost#idle_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "idleTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IdleTimeout
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#prefix_rewrite AlbVirtualHost#prefix_rewrite}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefixRewrite", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrefixRewrite
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#timeout AlbVirtualHost#timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timeout
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#upgrade_types AlbVirtualHost#upgrade_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "upgradeTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? UpgradeTypes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
