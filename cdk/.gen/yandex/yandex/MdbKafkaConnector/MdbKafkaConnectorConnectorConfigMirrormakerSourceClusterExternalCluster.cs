using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster")]
    public class MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster : yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#bootstrap_servers MdbKafkaConnector#bootstrap_servers}.</summary>
        [JsiiProperty(name: "bootstrapServers", typeJson: "{\"primitive\":\"string\"}")]
        public string BootstrapServers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#sasl_mechanism MdbKafkaConnector#sasl_mechanism}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saslMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SaslMechanism
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#sasl_password MdbKafkaConnector#sasl_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saslPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SaslPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#sasl_username MdbKafkaConnector#sasl_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saslUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SaslUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#security_protocol MdbKafkaConnector#security_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityProtocol
        {
            get;
            set;
        }
    }
}
