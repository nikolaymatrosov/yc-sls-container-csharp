using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouse")]
    public class MdbClickhouseClusterClickhouse : yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouse
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#resources MdbClickhouseCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseResources\"}")]
        public yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseResources Resources
        {
            get;
            set;
        }

        /// <summary>config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#config MdbClickhouseCluster#config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfig\"}", isOptional: true)]
        public yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig? Config
        {
            get;
            set;
        }
    }
}
