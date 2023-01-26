using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterZookeeper), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeper")]
    public interface IMdbClickhouseClusterZookeeper
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#resources MdbClickhouseCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeperResources\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeperResources? Resources
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterZookeeper), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeper")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeper
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#resources MdbClickhouseCluster#resources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeperResources\"}", isOptional: true)]
            public yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeperResources? Resources
            {
                get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeperResources?>();
            }
        }
    }
}
