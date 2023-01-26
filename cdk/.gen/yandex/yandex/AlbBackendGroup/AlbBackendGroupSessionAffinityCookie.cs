using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albBackendGroup.AlbBackendGroupSessionAffinityCookie")]
    public class AlbBackendGroupSessionAffinityCookie : yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityCookie
    {
        /// <summary>Name of the HTTP cookie.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#name AlbBackendGroup#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>TTL for the cookie (if not set, session cookie will be used).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#ttl AlbBackendGroup#ttl}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Ttl
        {
            get;
            set;
        }
    }
}
