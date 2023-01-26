using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IAlbBackendGroupHttpBackendHealthcheck), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheck")]
    public interface IAlbBackendGroupHttpBackendHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#interval AlbBackendGroup#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        string Interval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#timeout AlbBackendGroup#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}")]
        string Timeout
        {
            get;
        }

        /// <summary>grpc_healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#grpc_healthcheck AlbBackendGroup#grpc_healthcheck}
        /// </remarks>
        [JsiiProperty(name: "grpcHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck? GrpcHealthcheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#healthcheck_port AlbBackendGroup#healthcheck_port}.</summary>
        [JsiiProperty(name: "healthcheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthcheckPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#healthy_threshold AlbBackendGroup#healthy_threshold}.</summary>
        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthyThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#http_healthcheck AlbBackendGroup#http_healthcheck}
        /// </remarks>
        [JsiiProperty(name: "httpHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckHttpHealthcheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck? HttpHealthcheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#interval_jitter_percent AlbBackendGroup#interval_jitter_percent}.</summary>
        [JsiiProperty(name: "intervalJitterPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? IntervalJitterPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>stream_healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#stream_healthcheck AlbBackendGroup#stream_healthcheck}
        /// </remarks>
        [JsiiProperty(name: "streamHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckStreamHealthcheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck? StreamHealthcheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#unhealthy_threshold AlbBackendGroup#unhealthy_threshold}.</summary>
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnhealthyThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbBackendGroupHttpBackendHealthcheck), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheck")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#interval AlbBackendGroup#interval}.</summary>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
            public string Interval
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#timeout AlbBackendGroup#timeout}.</summary>
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}")]
            public string Timeout
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>grpc_healthcheck block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#grpc_healthcheck AlbBackendGroup#grpc_healthcheck}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpcHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck? GrpcHealthcheck
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#healthcheck_port AlbBackendGroup#healthcheck_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthcheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthcheckPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#healthy_threshold AlbBackendGroup#healthy_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthyThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>http_healthcheck block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#http_healthcheck AlbBackendGroup#http_healthcheck}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckHttpHealthcheck\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck? HttpHealthcheck
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#interval_jitter_percent AlbBackendGroup#interval_jitter_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "intervalJitterPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalJitterPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>stream_healthcheck block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#stream_healthcheck AlbBackendGroup#stream_healthcheck}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "streamHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckStreamHealthcheck\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck? StreamHealthcheck
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#unhealthy_threshold AlbBackendGroup#unhealthy_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnhealthyThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
