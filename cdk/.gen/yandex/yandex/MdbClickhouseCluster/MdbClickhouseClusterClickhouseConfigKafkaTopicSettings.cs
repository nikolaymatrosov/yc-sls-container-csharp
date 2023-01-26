using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaTopicSettings")]
    public class MdbClickhouseClusterClickhouseConfigKafkaTopicSettings : yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafkaTopicSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#sasl_mechanism MdbClickhouseCluster#sasl_mechanism}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saslMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SaslMechanism
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#sasl_password MdbClickhouseCluster#sasl_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saslPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SaslPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#sasl_username MdbClickhouseCluster#sasl_username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saslUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SaslUsername
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#security_protocol MdbClickhouseCluster#security_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityProtocol
        {
            get;
            set;
        }
    }
}
