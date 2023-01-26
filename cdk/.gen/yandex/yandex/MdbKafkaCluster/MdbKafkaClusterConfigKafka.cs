using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafka")]
    public class MdbKafkaClusterConfigKafka : yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafka
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#resources MdbKafkaCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaResources\"}")]
        public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaResources Resources
        {
            get;
            set;
        }

        /// <summary>kafka_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#kafka_config MdbKafkaCluster#kafka_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kafkaConfig", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaKafkaConfig\"}", isOptional: true)]
        public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaKafkaConfig? KafkaConfig
        {
            get;
            set;
        }
    }
}
