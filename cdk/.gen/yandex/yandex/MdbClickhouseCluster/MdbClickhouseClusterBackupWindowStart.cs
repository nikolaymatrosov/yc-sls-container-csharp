using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterBackupWindowStart")]
    public class MdbClickhouseClusterBackupWindowStart : yandex.MdbClickhouseCluster.IMdbClickhouseClusterBackupWindowStart
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#hours MdbClickhouseCluster#hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#minutes MdbClickhouseCluster#minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minutes
        {
            get;
            set;
        }
    }
}
