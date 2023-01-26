using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    [JsiiByValue(fqn: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue")]
    public class AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue : yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#exact AlbHttpRouter#exact}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Exact
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#prefix AlbHttpRouter#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }
    }
}
