using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiInterface(nativeType: typeof(IAlbVirtualHostRouteOptions), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteOptions")]
    public interface IAlbVirtualHostRouteOptions
    {
        /// <summary>rbac block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#rbac AlbVirtualHost#rbac}
        /// </remarks>
        [JsiiProperty(name: "rbac", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbac\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbac? Rbac
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbVirtualHostRouteOptions), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteOptions")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbVirtualHost.IAlbVirtualHostRouteOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rbac block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#rbac AlbVirtualHost#rbac}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rbac", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbac\"}", isOptional: true)]
            public yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbac? Rbac
            {
                get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbac?>();
            }
        }
    }
}
