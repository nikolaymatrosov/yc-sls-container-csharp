using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigResources")]
    public class MdbPostgresqlClusterConfigResources : yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#disk_size MdbPostgresqlCluster#disk_size}.</summary>
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
        public double DiskSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#resource_preset_id MdbPostgresqlCluster#resource_preset_id}.</summary>
        [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourcePresetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#disk_type_id MdbPostgresqlCluster#disk_type_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiskTypeId
        {
            get;
            set;
        }
    }
}
