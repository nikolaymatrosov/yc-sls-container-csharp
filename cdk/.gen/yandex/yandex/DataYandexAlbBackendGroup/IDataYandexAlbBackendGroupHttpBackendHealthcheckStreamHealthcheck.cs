using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IDataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck")]
    public interface IDataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#receive DataYandexAlbBackendGroup#receive}.</summary>
        [JsiiProperty(name: "receive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Receive
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#send DataYandexAlbBackendGroup#send}.</summary>
        [JsiiProperty(name: "send", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Send
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#receive DataYandexAlbBackendGroup#receive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "receive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Receive
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#send DataYandexAlbBackendGroup#send}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "send", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Send
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
