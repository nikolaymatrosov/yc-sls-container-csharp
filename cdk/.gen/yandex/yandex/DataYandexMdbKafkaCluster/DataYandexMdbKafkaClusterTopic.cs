using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterTopic")]
    public class DataYandexMdbKafkaClusterTopic : yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterTopic
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#cluster_id DataYandexMdbKafkaCluster#cluster_id}.</summary>
        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#name DataYandexMdbKafkaCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#partitions DataYandexMdbKafkaCluster#partitions}.</summary>
        [JsiiProperty(name: "partitions", typeJson: "{\"primitive\":\"number\"}")]
        public double Partitions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#replication_factor DataYandexMdbKafkaCluster#replication_factor}.</summary>
        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public double ReplicationFactor
        {
            get;
            set;
        }

        /// <summary>topic_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#topic_config DataYandexMdbKafkaCluster#topic_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topicConfig", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterTopicTopicConfig\"}", isOptional: true)]
        public yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterTopicTopicConfig? TopicConfig
        {
            get;
            set;
        }
    }
}
