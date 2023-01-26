using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention")]
    public interface IMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#age MdbClickhouseCluster#age}.</summary>
        [JsiiProperty(name: "age", typeJson: "{\"primitive\":\"number\"}")]
        double Age
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#precision MdbClickhouseCluster#precision}.</summary>
        [JsiiProperty(name: "precision", typeJson: "{\"primitive\":\"number\"}")]
        double Precision
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#age MdbClickhouseCluster#age}.</summary>
            [JsiiProperty(name: "age", typeJson: "{\"primitive\":\"number\"}")]
            public double Age
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#precision MdbClickhouseCluster#precision}.</summary>
            [JsiiProperty(name: "precision", typeJson: "{\"primitive\":\"number\"}")]
            public double Precision
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
