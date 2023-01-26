using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbGreenplumCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbGreenplumCluster.MdbGreenplumClusterMasterSubcluster")]
    public class MdbGreenplumClusterMasterSubcluster : yandex.MdbGreenplumCluster.IMdbGreenplumClusterMasterSubcluster
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#resources MdbGreenplumCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterMasterSubclusterResources\"}")]
        public yandex.MdbGreenplumCluster.IMdbGreenplumClusterMasterSubclusterResources Resources
        {
            get;
            set;
        }
    }
}
