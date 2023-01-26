using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IAlbBackendGroupSessionAffinityHeader), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupSessionAffinityHeader")]
    public interface IAlbBackendGroupSessionAffinityHeader
    {
        /// <summary>The name of the request header that will be used.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#header_name AlbBackendGroup#header_name}
        /// </remarks>
        [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
        string HeaderName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbBackendGroupSessionAffinityHeader), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupSessionAffinityHeader")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The name of the request header that will be used.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#header_name AlbBackendGroup#header_name}
            /// </remarks>
            [JsiiProperty(name: "headerName", typeJson: "{\"primitive\":\"string\"}")]
            public string HeaderName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
