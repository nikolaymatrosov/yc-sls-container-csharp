using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbKafkaCluster.MdbKafkaClusterUserPermission")]
    public class MdbKafkaClusterUserPermission : yandex.MdbKafkaCluster.IMdbKafkaClusterUserPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#role MdbKafkaCluster#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public string Role
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#topic_name MdbKafkaCluster#topic_name}.</summary>
        [JsiiProperty(name: "topicName", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicName
        {
            get;
            set;
        }
    }
}
