using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    [JsiiInterface(nativeType: typeof(IAlbHttpRouterRouteOptions), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouterRouteOptions")]
    public interface IAlbHttpRouterRouteOptions
    {
        /// <summary>rbac block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#rbac AlbHttpRouter#rbac}
        /// </remarks>
        [JsiiProperty(name: "rbac", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbac\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbac? Rbac
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbHttpRouterRouteOptions), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouterRouteOptions")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbHttpRouter.IAlbHttpRouterRouteOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rbac block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#rbac AlbHttpRouter#rbac}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rbac", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbac\"}", isOptional: true)]
            public yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbac? Rbac
            {
                get => GetInstanceProperty<yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbac?>();
            }
        }
    }
}
