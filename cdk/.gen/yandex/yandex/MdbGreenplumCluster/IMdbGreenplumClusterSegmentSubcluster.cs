using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbGreenplumCluster
{
    [JsiiInterface(nativeType: typeof(IMdbGreenplumClusterSegmentSubcluster), fullyQualifiedName: "yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubcluster")]
    public interface IMdbGreenplumClusterSegmentSubcluster
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#resources MdbGreenplumCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterResources\"}")]
        yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubclusterResources Resources
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbGreenplumClusterSegmentSubcluster), fullyQualifiedName: "yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubcluster")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubcluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#resources MdbGreenplumCluster#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterResources\"}")]
            public yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubclusterResources Resources
            {
                get => GetInstanceProperty<yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubclusterResources>()!;
            }
        }
    }
}
