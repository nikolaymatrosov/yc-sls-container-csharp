using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormaker")]
    public class MdbKafkaConnectorConnectorConfigMirrormaker : yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormaker
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#replication_factor MdbKafkaConnector#replication_factor}.</summary>
        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public double ReplicationFactor
        {
            get;
            set;
        }

        /// <summary>source_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#source_cluster MdbKafkaConnector#source_cluster}
        /// </remarks>
        [JsiiProperty(name: "sourceCluster", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceCluster\"}")]
        public yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster SourceCluster
        {
            get;
            set;
        }

        /// <summary>target_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#target_cluster MdbKafkaConnector#target_cluster}
        /// </remarks>
        [JsiiProperty(name: "targetCluster", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerTargetCluster\"}")]
        public yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerTargetCluster TargetCluster
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#topics MdbKafkaConnector#topics}.</summary>
        [JsiiProperty(name: "topics", typeJson: "{\"primitive\":\"string\"}")]
        public string Topics
        {
            get;
            set;
        }
    }
}
