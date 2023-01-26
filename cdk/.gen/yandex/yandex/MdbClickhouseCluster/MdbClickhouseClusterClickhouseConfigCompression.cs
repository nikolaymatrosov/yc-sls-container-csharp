using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompression")]
    public class MdbClickhouseClusterClickhouseConfigCompression : yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigCompression
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#method MdbClickhouseCluster#method}.</summary>
        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
        public string Method
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_part_size MdbClickhouseCluster#min_part_size}.</summary>
        [JsiiProperty(name: "minPartSize", typeJson: "{\"primitive\":\"number\"}")]
        public double MinPartSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_part_size_ratio MdbClickhouseCluster#min_part_size_ratio}.</summary>
        [JsiiProperty(name: "minPartSizeRatio", typeJson: "{\"primitive\":\"number\"}")]
        public double MinPartSizeRatio
        {
            get;
            set;
        }
    }
}
