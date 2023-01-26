using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention")]
    public class MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention : yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#age MdbClickhouseCluster#age}.</summary>
        [JsiiProperty(name: "age", typeJson: "{\"primitive\":\"number\"}")]
        public double Age
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#precision MdbClickhouseCluster#precision}.</summary>
        [JsiiProperty(name: "precision", typeJson: "{\"primitive\":\"number\"}")]
        public double Precision
        {
            get;
            set;
        }
    }
}
