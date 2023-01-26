using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeperResources")]
    public class MdbClickhouseClusterZookeeperResources : yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeperResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#disk_size MdbClickhouseCluster#disk_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DiskSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#disk_type_id MdbClickhouseCluster#disk_type_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiskTypeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#resource_preset_id MdbClickhouseCluster#resource_preset_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourcePresetId
        {
            get;
            set;
        }
    }
}
