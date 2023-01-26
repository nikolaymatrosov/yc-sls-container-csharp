using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteRouteOptionsRbac), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbac")]
    public interface IAlbVirtualHostRouteRouteOptionsRbac
    {
        /// <summary>principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#principals AlbVirtualHost#principals}
        /// </remarks>
        [JsiiProperty(name: "principals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipals\"},\"kind\":\"array\"}}]}}")]
        object Principals
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#action AlbVirtualHost#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteRouteOptionsRbac), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbac")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbac
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>principals block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#principals AlbVirtualHost#principals}
            /// </remarks>
            [JsiiProperty(name: "principals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipals\"},\"kind\":\"array\"}}]}}")]
            public object Principals
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#action AlbVirtualHost#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
