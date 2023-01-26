using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterClickhouseConfigCompression), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompression")]
    public interface IMdbClickhouseClusterClickhouseConfigCompression
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#method MdbClickhouseCluster#method}.</summary>
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
        string Method
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_part_size MdbClickhouseCluster#min_part_size}.</summary>
        [JsiiProperty(name: "minPartSize", typeJson: "{\"primitive\":\"number\"}")]
        double MinPartSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_part_size_ratio MdbClickhouseCluster#min_part_size_ratio}.</summary>
        [JsiiProperty(name: "minPartSizeRatio", typeJson: "{\"primitive\":\"number\"}")]
        double MinPartSizeRatio
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterClickhouseConfigCompression), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompression")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigCompression
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#method MdbClickhouseCluster#method}.</summary>
            [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
            public string Method
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_part_size MdbClickhouseCluster#min_part_size}.</summary>
            [JsiiProperty(name: "minPartSize", typeJson: "{\"primitive\":\"number\"}")]
            public double MinPartSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_part_size_ratio MdbClickhouseCluster#min_part_size_ratio}.</summary>
            [JsiiProperty(name: "minPartSizeRatio", typeJson: "{\"primitive\":\"number\"}")]
            public double MinPartSizeRatio
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
