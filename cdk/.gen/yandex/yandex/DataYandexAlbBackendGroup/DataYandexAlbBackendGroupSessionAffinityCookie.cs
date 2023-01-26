using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityCookie")]
    public class DataYandexAlbBackendGroupSessionAffinityCookie : yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityCookie
    {
        /// <summary>TTL for the cookie (if not set, session cookie will be used).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#ttl DataYandexAlbBackendGroup#ttl}
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
