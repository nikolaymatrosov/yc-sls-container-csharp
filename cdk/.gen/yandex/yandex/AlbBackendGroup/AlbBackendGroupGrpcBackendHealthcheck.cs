using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheck")]
    public class AlbBackendGroupGrpcBackendHealthcheck : yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#interval AlbBackendGroup#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public string Interval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#timeout AlbBackendGroup#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}")]
        public string Timeout
        {
            get;
            set;
        }

        /// <summary>grpc_healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#grpc_healthcheck AlbBackendGroup#grpc_healthcheck}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "grpcHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck\"}", isOptional: true)]
        public yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck? GrpcHealthcheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#healthcheck_port AlbBackendGroup#healthcheck_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthcheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthcheckPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#healthy_threshold AlbBackendGroup#healthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HealthyThreshold
        {
            get;
            set;
        }

        /// <summary>http_healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#http_healthcheck AlbBackendGroup#http_healthcheck}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck\"}", isOptional: true)]
        public yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck? HttpHealthcheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#interval_jitter_percent AlbBackendGroup#interval_jitter_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "intervalJitterPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IntervalJitterPercent
        {
            get;
            set;
        }

        /// <summary>stream_healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#stream_healthcheck AlbBackendGroup#stream_healthcheck}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "streamHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck\"}", isOptional: true)]
        public yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck? StreamHealthcheck
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#unhealthy_threshold AlbBackendGroup#unhealthy_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UnhealthyThreshold
        {
            get;
            set;
        }
    }
}
