using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteRouteOptions), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteRouteOptions")]
    public interface IAlbVirtualHostRouteRouteOptions
    {
        /// <summary>rbac block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#rbac AlbVirtualHost#rbac}
        /// </remarks>
        [JsiiProperty(name: "rbac", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbac\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbac? Rbac
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteRouteOptions), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteRouteOptions")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rbac block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#rbac AlbVirtualHost#rbac}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rbac", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbac\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbac? Rbac
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbac?>();
            }
        }
    }
}
