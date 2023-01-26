using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterUserQuota), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterUserQuota")]
    public interface IMdbClickhouseClusterUserQuota
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#interval_duration MdbClickhouseCluster#interval_duration}.</summary>
        [JsiiProperty(name: "intervalDuration", typeJson: "{\"primitive\":\"number\"}")]
        double IntervalDuration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#errors MdbClickhouseCluster#errors}.</summary>
        [JsiiProperty(name: "errors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Errors
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#execution_time MdbClickhouseCluster#execution_time}.</summary>
        [JsiiProperty(name: "executionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExecutionTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#queries MdbClickhouseCluster#queries}.</summary>
        [JsiiProperty(name: "queries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Queries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#read_rows MdbClickhouseCluster#read_rows}.</summary>
        [JsiiProperty(name: "readRows", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadRows
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#result_rows MdbClickhouseCluster#result_rows}.</summary>
        [JsiiProperty(name: "resultRows", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ResultRows
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterUserQuota), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterUserQuota")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterUserQuota
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#interval_duration MdbClickhouseCluster#interval_duration}.</summary>
            [JsiiProperty(name: "intervalDuration", typeJson: "{\"primitive\":\"number\"}")]
            public double IntervalDuration
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#errors MdbClickhouseCluster#errors}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "errors", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Errors
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#execution_time MdbClickhouseCluster#execution_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "executionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExecutionTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#queries MdbClickhouseCluster#queries}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Queries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#read_rows MdbClickhouseCluster#read_rows}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readRows", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadRows
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#result_rows MdbClickhouseCluster#result_rows}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resultRows", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ResultRows
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
