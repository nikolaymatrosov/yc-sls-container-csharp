using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbGreenplumCluster
{
    [JsiiByValue(fqn: "yandex.mdbGreenplumCluster.MdbGreenplumClusterPoolerConfig")]
    public class MdbGreenplumClusterPoolerConfig : yandex.MdbGreenplumCluster.IMdbGreenplumClusterPoolerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#pool_client_idle_timeout MdbGreenplumCluster#pool_client_idle_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolClientIdleTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PoolClientIdleTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#pooling_mode MdbGreenplumCluster#pooling_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PoolingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster#pool_size MdbGreenplumCluster#pool_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PoolSize
        {
            get;
            set;
        }
    }
}
