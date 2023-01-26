using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatch")]
    public class AlbVirtualHostRouteHttpRouteHttpMatch : yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#http_method AlbVirtualHost#http_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpMethod", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HttpMethod
        {
            get;
            set;
        }

        /// <summary>path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#path AlbVirtualHost#path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatchPath\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatchPath? Path
        {
            get;
            set;
        }
    }
}
