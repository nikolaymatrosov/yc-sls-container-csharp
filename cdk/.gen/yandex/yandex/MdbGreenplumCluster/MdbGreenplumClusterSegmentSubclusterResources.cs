using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbGreenplumCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterResources")]
    public class MdbGreenplumClusterSegmentSubclusterResources : yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubclusterResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#disk_size MdbGreenplumCluster#disk_size}.</summary>
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
        public double DiskSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#disk_type_id MdbGreenplumCluster#disk_type_id}.</summary>
        [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}")]
        public string DiskTypeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#resource_preset_id MdbGreenplumCluster#resource_preset_id}.</summary>
        [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourcePresetId
        {
            get;
            set;
        }
    }
}
