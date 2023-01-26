using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeper")]
    public class MdbClickhouseClusterZookeeper : yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeper
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#resources MdbClickhouseCluster#resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeperResources\"}", isOptional: true)]
        public yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeperResources? Resources
        {
            get;
            set;
        }
    }
}
