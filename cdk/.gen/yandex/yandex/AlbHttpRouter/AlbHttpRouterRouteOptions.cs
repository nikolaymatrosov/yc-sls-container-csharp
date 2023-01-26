using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    [JsiiByValue(fqn: "yandex.albHttpRouter.AlbHttpRouterRouteOptions")]
    public class AlbHttpRouterRouteOptions : yandex.AlbHttpRouter.IAlbHttpRouterRouteOptions
    {
        /// <summary>rbac block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#rbac AlbHttpRouter#rbac}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rbac", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbac\"}", isOptional: true)]
        public yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbac? Rbac
        {
            get;
            set;
        }
    }
}
