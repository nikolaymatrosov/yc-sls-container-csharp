using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaClusterConfigZookeeperResources), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeperResources")]
    public interface IMdbKafkaClusterConfigZookeeperResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#disk_size MdbKafkaCluster#disk_size}.</summary>
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#disk_type_id MdbKafkaCluster#disk_type_id}.</summary>
        [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiskTypeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#resource_preset_id MdbKafkaCluster#resource_preset_id}.</summary>
        [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourcePresetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaClusterConfigZookeeperResources), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeperResources")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeperResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#disk_size MdbKafkaCluster#disk_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#disk_type_id MdbKafkaCluster#disk_type_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiskTypeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#resource_preset_id MdbKafkaCluster#resource_preset_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourcePresetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
