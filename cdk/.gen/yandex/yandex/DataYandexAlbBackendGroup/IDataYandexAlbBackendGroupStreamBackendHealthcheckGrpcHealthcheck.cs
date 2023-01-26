using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IDataYandexAlbBackendGroupStreamBackendHealthcheckGrpcHealthcheck), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendHealthcheckGrpcHealthcheck")]
    public interface IDataYandexAlbBackendGroupStreamBackendHealthcheckGrpcHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#service_name DataYandexAlbBackendGroup#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexAlbBackendGroupStreamBackendHealthcheckGrpcHealthcheck), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendHealthcheckGrpcHealthcheck")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendHealthcheckGrpcHealthcheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#service_name DataYandexAlbBackendGroup#service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
