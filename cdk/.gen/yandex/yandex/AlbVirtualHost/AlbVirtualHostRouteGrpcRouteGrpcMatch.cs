using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatch")]
    public class AlbVirtualHostRouteGrpcRouteGrpcMatch : yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatch
    {
        /// <summary>fqmn block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#fqmn AlbVirtualHost#fqmn}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fqmn", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatchFqmn\"}", isOptional: true)]
        public yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatchFqmn? Fqmn
        {
            get;
            set;
        }
    }
}
