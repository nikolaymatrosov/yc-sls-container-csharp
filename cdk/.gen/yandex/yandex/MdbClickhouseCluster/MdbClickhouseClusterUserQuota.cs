using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterUserQuota")]
    public class MdbClickhouseClusterUserQuota : yandex.MdbClickhouseCluster.IMdbClickhouseClusterUserQuota
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#interval_duration MdbClickhouseCluster#interval_duration}.</summary>
        [JsiiProperty(name: "intervalDuration", typeJson: "{\"primitive\":\"number\"}")]
        public double IntervalDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#errors MdbClickhouseCluster#errors}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Errors
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#execution_time MdbClickhouseCluster#execution_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "executionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExecutionTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#queries MdbClickhouseCluster#queries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Queries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#read_rows MdbClickhouseCluster#read_rows}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readRows", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadRows
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#result_rows MdbClickhouseCluster#result_rows}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resultRows", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ResultRows
        {
            get;
            set;
        }
    }
}
