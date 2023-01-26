using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipalsHeader")]
    public class AlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipalsHeader : yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipalsHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#name AlbVirtualHost#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>value block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#value AlbVirtualHost#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue? Value
        {
            get;
            set;
        }
    }
}
