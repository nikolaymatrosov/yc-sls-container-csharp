using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albBackendGroup.AlbBackendGroupSessionAffinityHeader")]
    public class AlbBackendGroupSessionAffinityHeader : yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityHeader
    {
        /// <summary>The name of the request header that will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#header_name AlbBackendGroup#header_name}
        /// </remarks>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        public string HeaderName
        {
            get;
            set;
        }
    }
}
