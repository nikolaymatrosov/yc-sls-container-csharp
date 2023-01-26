using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRouteRouteOptions")]
    public class AlbVirtualHostRouteRouteOptions : yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptions
    {
        /// <summary>rbac block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#rbac AlbVirtualHost#rbac}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rbac", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbac\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbac? Rbac
        {
            get;
            set;
        }
    }
}
