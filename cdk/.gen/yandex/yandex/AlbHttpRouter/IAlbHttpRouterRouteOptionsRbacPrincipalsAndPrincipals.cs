using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    [JsiiInterface(nativeType: typeof(IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals")]
    public interface IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#any AlbHttpRouter#any}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#header AlbHttpRouter#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader? Header
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#remote_ip AlbHttpRouter#remote_ip}.</summary>
        [JsiiProperty(name: "remoteIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RemoteIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipals
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#any AlbHttpRouter#any}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "any", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Any
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#header AlbHttpRouter#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader\"}", isOptional: true)]
            public yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader? Header
            {
                get => GetInstanceProperty<yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#remote_ip AlbHttpRouter#remote_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "remoteIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RemoteIp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
