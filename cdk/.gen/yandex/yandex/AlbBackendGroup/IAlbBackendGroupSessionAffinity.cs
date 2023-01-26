using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IAlbBackendGroupSessionAffinity), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupSessionAffinity")]
    public interface IAlbBackendGroupSessionAffinity
    {
        /// <summary>connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#connection AlbBackendGroup#connection}
        /// </remarks>
        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityConnection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityConnection? Connection
        {
            get
            {
                return null;
            }
        }

        /// <summary>cookie block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#cookie AlbBackendGroup#cookie}
        /// </remarks>
        [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityCookie\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityCookie? Cookie
        {
            get
            {
                return null;
            }
        }

        /// <summary>header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#header AlbBackendGroup#header}
        /// </remarks>
        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityHeader? Header
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbBackendGroupSessionAffinity), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupSessionAffinity")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>connection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#connection AlbBackendGroup#connection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityConnection\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityConnection? Connection
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityConnection?>();
            }

            /// <summary>cookie block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#cookie AlbBackendGroup#cookie}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityCookie\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityCookie? Cookie
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityCookie?>();
            }

            /// <summary>header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#header AlbBackendGroup#header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityHeader\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityHeader? Header
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityHeader?>();
            }
        }
    }
}
