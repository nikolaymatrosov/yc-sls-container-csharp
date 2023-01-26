using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbKafkaCluster.MdbKafkaClusterTopic")]
    public class MdbKafkaClusterTopic : yandex.MdbKafkaCluster.IMdbKafkaClusterTopic
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#name MdbKafkaCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#partitions MdbKafkaCluster#partitions}.</summary>
        [JsiiProperty(name: "partitions", typeJson: "{\"primitive\":\"number\"}")]
        public double Partitions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#replication_factor MdbKafkaCluster#replication_factor}.</summary>
        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public double ReplicationFactor
        {
            get;
            set;
        }

        /// <summary>topic_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#topic_config MdbKafkaCluster#topic_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topicConfig", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterTopicTopicConfig\"}", isOptional: true)]
        public yandex.MdbKafkaCluster.IMdbKafkaClusterTopicTopicConfig? TopicConfig
        {
            get;
            set;
        }
    }
}
