using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    [JsiiInterface(nativeType: typeof(IAlbHttpRouterRouteOptionsRbac), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbac")]
    public interface IAlbHttpRouterRouteOptionsRbac
    {
        /// <summary>principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#principals AlbHttpRouter#principals}
        /// </remarks>
        [JsiiProperty(name: "principals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipals\"},\"kind\":\"array\"}}]}}")]
        object Principals
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#action AlbHttpRouter#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbHttpRouterRouteOptionsRbac), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbac")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbac
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>principals block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#principals AlbHttpRouter#principals}
            /// </remarks>
            [JsiiProperty(name: "principals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipals\"},\"kind\":\"array\"}}]}}")]
            public object Principals
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#action AlbHttpRouter#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
