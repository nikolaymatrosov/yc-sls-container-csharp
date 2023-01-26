using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheck")]
    public class DataYandexAlbBackendGroupHttpBackendHealthcheck : yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheck
    {
        /// <summary>grpc_healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#grpc_healthcheck DataYandexAlbBackendGroup#grpc_healthcheck}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpcHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck\"}", isOptional: true)]
        public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck? GrpcHealthcheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#healthcheck_port DataYandexAlbBackendGroup#healthcheck_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthcheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthcheckPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#healthy_threshold DataYandexAlbBackendGroup#healthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthyThreshold
        {
            get;
            set;
        }

        /// <summary>http_healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#http_healthcheck DataYandexAlbBackendGroup#http_healthcheck}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck\"}", isOptional: true)]
        public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck? HttpHealthcheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#interval_jitter_percent DataYandexAlbBackendGroup#interval_jitter_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intervalJitterPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalJitterPercent
        {
            get;
            set;
        }

        /// <summary>stream_healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#stream_healthcheck DataYandexAlbBackendGroup#stream_healthcheck}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "streamHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck\"}", isOptional: true)]
        public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck? StreamHealthcheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#unhealthy_threshold DataYandexAlbBackendGroup#unhealthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnhealthyThreshold
        {
            get;
            set;
        }
    }
}
