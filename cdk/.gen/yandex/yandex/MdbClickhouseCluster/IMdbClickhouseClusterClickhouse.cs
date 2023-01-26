using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterClickhouse), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouse")]
    public interface IMdbClickhouseClusterClickhouse
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#resources MdbClickhouseCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseResources\"}")]
        yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseResources Resources
        {
            get;
        }

        /// <summary>config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#config MdbClickhouseCluster#config}
        /// </remarks>
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig? Config
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterClickhouse), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouse")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#resources MdbClickhouseCluster#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseResources\"}")]
            public yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseResources Resources
            {
                get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseResources>()!;
            }

            /// <summary>config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#config MdbClickhouseCluster#config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfig\"}", isOptional: true)]
            public yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig? Config
            {
                get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig?>();
            }
        }
    }
}
