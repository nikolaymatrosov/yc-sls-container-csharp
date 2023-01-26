using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipals), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipals")]
    public interface IAlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipals
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#any AlbVirtualHost#any}.</summary>
        [JsiiProperty(name: "any", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Any
        {
            get
            {
                return null;
            }
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#header AlbVirtualHost#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipalsHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipalsHeader? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#remote_ip AlbVirtualHost#remote_ip}.</summary>
        [JsiiProperty(name: "remoteIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoteIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipals), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipals")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipals
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#any AlbVirtualHost#any}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "any", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Any
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#header AlbVirtualHost#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipalsHeader\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipalsHeader? Header
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipalsHeader?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#remote_ip AlbVirtualHost#remote_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoteIp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
