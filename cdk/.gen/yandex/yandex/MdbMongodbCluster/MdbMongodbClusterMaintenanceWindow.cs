using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbMongodbCluster.MdbMongodbClusterMaintenanceWindow")]
    public class MdbMongodbClusterMaintenanceWindow : yandex.MdbMongodbCluster.IMdbMongodbClusterMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#type MdbMongodbCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#day MdbMongodbCluster#day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Day
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#hour MdbMongodbCluster#hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hour
        {
            get;
            set;
        }
    }
}
