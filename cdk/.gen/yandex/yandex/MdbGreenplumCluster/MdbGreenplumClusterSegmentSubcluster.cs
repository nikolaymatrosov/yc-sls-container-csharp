using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbGreenplumCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubcluster")]
    public class MdbGreenplumClusterSegmentSubcluster : yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubcluster
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#resources MdbGreenplumCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterResources\"}")]
        public yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubclusterResources Resources
        {
            get;
            set;
        }
    }
}
