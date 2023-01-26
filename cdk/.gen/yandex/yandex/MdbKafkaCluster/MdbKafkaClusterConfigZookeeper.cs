using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiByValue(fqn: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeper")]
    public class MdbKafkaClusterConfigZookeeper : yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeper
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#resources MdbKafkaCluster#resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeperResources\"}", isOptional: true)]
        public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeperResources? Resources
        {
            get;
            set;
        }
    }
}
