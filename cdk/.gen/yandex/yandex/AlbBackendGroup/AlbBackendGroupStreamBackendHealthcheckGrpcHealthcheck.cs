using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.albBackendGroup.AlbBackendGroupStreamBackendHealthcheckGrpcHealthcheck")]
    public class AlbBackendGroupStreamBackendHealthcheckGrpcHealthcheck : yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendHealthcheckGrpcHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#service_name AlbBackendGroup#service_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceName
        {
            get;
            set;
        }
    }
}
