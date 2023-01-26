using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.albBackendGroup.AlbBackendGroupSessionAffinity")]
    public class AlbBackendGroupSessionAffinity : yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinity
    {
        /// <summary>connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#connection AlbBackendGroup#connection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityConnection\"}", isOptional: true)]
        public yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityConnection? Connection
        {
            get;
            set;
        }

        /// <summary>cookie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#cookie AlbBackendGroup#cookie}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityCookie\"}", isOptional: true)]
        public yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityCookie? Cookie
        {
            get;
            set;
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#header AlbBackendGroup#header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityHeader\"}", isOptional: true)]
        public yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityHeader? Header
        {
            get;
            set;
        }
    }
}
