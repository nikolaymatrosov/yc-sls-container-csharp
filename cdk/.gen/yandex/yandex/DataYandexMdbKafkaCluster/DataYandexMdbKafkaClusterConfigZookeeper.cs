using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    [JsiiByValue(fqn: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeper")]
    public class DataYandexMdbKafkaClusterConfigZookeeper : yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeper
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#resources DataYandexMdbKafkaCluster#resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeperResources\"}", isOptional: true)]
        public yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeperResources? Resources
        {
            get;
            set;
        }
    }
}
