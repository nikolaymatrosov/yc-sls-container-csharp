using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafka")]
    public class DataYandexMdbKafkaClusterConfigKafka : yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafka
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#resources DataYandexMdbKafkaCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResources\"}")]
        public yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaResources Resources
        {
            get;
            set;
        }

        /// <summary>kafka_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#kafka_config DataYandexMdbKafkaCluster#kafka_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kafkaConfig", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaKafkaConfig\"}", isOptional: true)]
        public yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaKafkaConfig? KafkaConfig
        {
            get;
            set;
        }
    }
}
