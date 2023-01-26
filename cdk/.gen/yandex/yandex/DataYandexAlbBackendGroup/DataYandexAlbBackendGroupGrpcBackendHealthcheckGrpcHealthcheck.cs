using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck")]
    public class DataYandexAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck : yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#service_name DataYandexAlbBackendGroup#service_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceName
        {
            get;
            set;
        }
    }
}
