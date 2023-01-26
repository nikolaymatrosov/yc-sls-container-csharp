using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IDataYandexAlbBackendGroupSessionAffinityCookie), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityCookie")]
    public interface IDataYandexAlbBackendGroupSessionAffinityCookie
    {
        /// <summary>TTL for the cookie (if not set, session cookie will be used).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#ttl DataYandexAlbBackendGroup#ttl}
        /// </remarks>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ttl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexAlbBackendGroupSessionAffinityCookie), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityCookie")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityCookie
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>TTL for the cookie (if not set, session cookie will be used).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#ttl DataYandexAlbBackendGroup#ttl}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ttl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
