using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader")]
    public class AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader : yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#name AlbHttpRouter#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router#value AlbHttpRouter#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue\"}", isOptional: true)]
        public yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue? Value
        {
            get;
            set;
        }
    }
}
