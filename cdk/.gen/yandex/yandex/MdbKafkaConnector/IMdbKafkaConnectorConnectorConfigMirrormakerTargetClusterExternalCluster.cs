using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalCluster), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalCluster")]
    public interface IMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#bootstrap_servers MdbKafkaConnector#bootstrap_servers}.</summary>
        [JsiiProperty(name: "bootstrapServers", typeJson: "{\"primitive\":\"string\"}")]
        string BootstrapServers
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#sasl_mechanism MdbKafkaConnector#sasl_mechanism}.</summary>
        [JsiiProperty(name: "saslMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SaslMechanism
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#sasl_password MdbKafkaConnector#sasl_password}.</summary>
        [JsiiProperty(name: "saslPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SaslPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#sasl_username MdbKafkaConnector#sasl_username}.</summary>
        [JsiiProperty(name: "saslUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SaslUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#security_protocol MdbKafkaConnector#security_protocol}.</summary>
        [JsiiProperty(name: "securityProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalCluster), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalCluster")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#bootstrap_servers MdbKafkaConnector#bootstrap_servers}.</summary>
            [JsiiProperty(name: "bootstrapServers", typeJson: "{\"primitive\":\"string\"}")]
            public string BootstrapServers
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#sasl_mechanism MdbKafkaConnector#sasl_mechanism}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saslMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SaslMechanism
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#sasl_password MdbKafkaConnector#sasl_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saslPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SaslPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#sasl_username MdbKafkaConnector#sasl_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saslUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SaslUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#security_protocol MdbKafkaConnector#security_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
