using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbKafkaClusterConfigKafkaResources), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResources")]
    public interface IDataYandexMdbKafkaClusterConfigKafkaResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#disk_size DataYandexMdbKafkaCluster#disk_size}.</summary>
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
        double DiskSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#disk_type_id DataYandexMdbKafkaCluster#disk_type_id}.</summary>
        [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}")]
        string DiskTypeId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#resource_preset_id DataYandexMdbKafkaCluster#resource_preset_id}.</summary>
        [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourcePresetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbKafkaClusterConfigKafkaResources), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResources")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#disk_size DataYandexMdbKafkaCluster#disk_size}.</summary>
            [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
            public double DiskSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#disk_type_id DataYandexMdbKafkaCluster#disk_type_id}.</summary>
            [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}")]
            public string DiskTypeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#resource_preset_id DataYandexMdbKafkaCluster#resource_preset_id}.</summary>
            [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourcePresetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
