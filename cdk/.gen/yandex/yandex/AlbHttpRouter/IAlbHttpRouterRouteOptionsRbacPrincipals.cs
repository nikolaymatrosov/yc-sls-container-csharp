using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    [JsiiInterface(nativeType: typeof(IAlbHttpRouterRouteOptionsRbacPrincipals), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipals")]
    public interface IAlbHttpRouterRouteOptionsRbacPrincipals
    {
        /// <summary>and_principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#and_principals AlbHttpRouter#and_principals}
        /// </remarks>
        [JsiiProperty(name: "andPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals\"},\"kind\":\"array\"}}]}}")]
        object AndPrincipals
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbHttpRouterRouteOptionsRbacPrincipals), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipals")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipals
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>and_principals block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#and_principals AlbHttpRouter#and_principals}
            /// </remarks>
            [JsiiProperty(name: "andPrincipals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals\"},\"kind\":\"array\"}}]}}")]
            public object AndPrincipals
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
