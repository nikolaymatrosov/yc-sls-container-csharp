using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbGreenplumCluster
{
    [JsiiByValue(fqn: "yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterPoolerConfig")]
    public class DataYandexMdbGreenplumClusterPoolerConfig : yandex.DataYandexMdbGreenplumCluster.IDataYandexMdbGreenplumClusterPoolerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster#pool_client_idle_timeout DataYandexMdbGreenplumCluster#pool_client_idle_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolClientIdleTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PoolClientIdleTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster#pooling_mode DataYandexMdbGreenplumCluster#pooling_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PoolingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster#pool_size DataYandexMdbGreenplumCluster#pool_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PoolSize
        {
            get;
            set;
        }
    }
}
