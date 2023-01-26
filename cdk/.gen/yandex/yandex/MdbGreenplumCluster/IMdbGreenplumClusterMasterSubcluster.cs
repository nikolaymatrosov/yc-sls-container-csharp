using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbGreenplumCluster
{
    [JsiiInterface(nativeType: typeof(IMdbGreenplumClusterMasterSubcluster), fullyQualifiedName: "yandex.mdbGreenplumCluster.MdbGreenplumClusterMasterSubcluster")]
    public interface IMdbGreenplumClusterMasterSubcluster
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#resources MdbGreenplumCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterMasterSubclusterResources\"}")]
        yandex.MdbGreenplumCluster.IMdbGreenplumClusterMasterSubclusterResources Resources
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbGreenplumClusterMasterSubcluster), fullyQualifiedName: "yandex.mdbGreenplumCluster.MdbGreenplumClusterMasterSubcluster")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbGreenplumCluster.IMdbGreenplumClusterMasterSubcluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#resources MdbGreenplumCluster#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterMasterSubclusterResources\"}")]
            public yandex.MdbGreenplumCluster.IMdbGreenplumClusterMasterSubclusterResources Resources
            {
                get => GetInstanceProperty<yandex.MdbGreenplumCluster.IMdbGreenplumClusterMasterSubclusterResources>()!;
            }
        }
    }
}
