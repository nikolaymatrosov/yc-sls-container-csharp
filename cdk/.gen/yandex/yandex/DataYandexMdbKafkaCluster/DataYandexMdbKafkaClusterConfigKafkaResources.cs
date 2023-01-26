using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResources")]
    public class DataYandexMdbKafkaClusterConfigKafkaResources : yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#disk_size DataYandexMdbKafkaCluster#disk_size}.</summary>
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
        public double DiskSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#disk_type_id DataYandexMdbKafkaCluster#disk_type_id}.</summary>
        [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}")]
        public string DiskTypeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#resource_preset_id DataYandexMdbKafkaCluster#resource_preset_id}.</summary>
        [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourcePresetId
        {
            get;
            set;
        }
    }
}
