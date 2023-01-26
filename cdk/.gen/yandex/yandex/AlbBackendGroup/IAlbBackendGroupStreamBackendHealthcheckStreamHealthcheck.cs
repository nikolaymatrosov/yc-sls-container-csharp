using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IAlbBackendGroupStreamBackendHealthcheckStreamHealthcheck), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupStreamBackendHealthcheckStreamHealthcheck")]
    public interface IAlbBackendGroupStreamBackendHealthcheckStreamHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#receive AlbBackendGroup#receive}.</summary>
        [JsiiProperty(name: "receive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Receive
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#send AlbBackendGroup#send}.</summary>
        [JsiiProperty(name: "send", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Send
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbBackendGroupStreamBackendHealthcheckStreamHealthcheck), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupStreamBackendHealthcheckStreamHealthcheck")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendHealthcheckStreamHealthcheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#receive AlbBackendGroup#receive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "receive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Receive
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#send AlbBackendGroup#send}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "send", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Send
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
