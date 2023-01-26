using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IDataYandexAlbBackendGroupGrpcBackendHealthcheck), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheck")]
    public interface IDataYandexAlbBackendGroupGrpcBackendHealthcheck
    {
        /// <summary>grpc_healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#grpc_healthcheck DataYandexAlbBackendGroup#grpc_healthcheck}
        /// </remarks>
        [JsiiProperty(name: "grpcHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck? GrpcHealthcheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#healthcheck_port DataYandexAlbBackendGroup#healthcheck_port}.</summary>
        [JsiiProperty(name: "healthcheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HealthcheckPort
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#healthy_threshold DataYandexAlbBackendGroup#healthy_threshold}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#http_healthcheck DataYandexAlbBackendGroup#http_healthcheck}
        /// </remarks>
        [JsiiProperty(name: "httpHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck? HttpHealthcheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#interval_jitter_percent DataYandexAlbBackendGroup#interval_jitter_percent}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#stream_healthcheck DataYandexAlbBackendGroup#stream_healthcheck}
        /// </remarks>
        [JsiiProperty(name: "streamHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck? StreamHealthcheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#unhealthy_threshold DataYandexAlbBackendGroup#unhealthy_threshold}.</summary>
        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UnhealthyThreshold
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexAlbBackendGroupGrpcBackendHealthcheck), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheck")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>grpc_healthcheck block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#grpc_healthcheck DataYandexAlbBackendGroup#grpc_healthcheck}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "grpcHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck\"}", isOptional: true)]
            public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck? GrpcHealthcheck
            {
                get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#healthcheck_port DataYandexAlbBackendGroup#healthcheck_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthcheckPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthcheckPort
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#healthy_threshold DataYandexAlbBackendGroup#healthy_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HealthyThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>http_healthcheck block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#http_healthcheck DataYandexAlbBackendGroup#http_healthcheck}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck\"}", isOptional: true)]
            public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck? HttpHealthcheck
            {
                get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#interval_jitter_percent DataYandexAlbBackendGroup#interval_jitter_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "intervalJitterPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? IntervalJitterPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>stream_healthcheck block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#stream_healthcheck DataYandexAlbBackendGroup#stream_healthcheck}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "streamHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck\"}", isOptional: true)]
            public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck? StreamHealthcheck
            {
                get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#unhealthy_threshold DataYandexAlbBackendGroup#unhealthy_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UnhealthyThreshold
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
