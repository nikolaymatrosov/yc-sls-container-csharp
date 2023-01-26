using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterUserPermission")]
    public class DataYandexMdbKafkaClusterUserPermission : yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterUserPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#role DataYandexMdbKafkaCluster#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public string Role
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#topic_name DataYandexMdbKafkaCluster#topic_name}.</summary>
        [JsiiProperty(name: "topicName", typeJson: "{\"primitive\":\"string\"}")]
        public string TopicName
        {
            get;
            set;
        }
    }
}
