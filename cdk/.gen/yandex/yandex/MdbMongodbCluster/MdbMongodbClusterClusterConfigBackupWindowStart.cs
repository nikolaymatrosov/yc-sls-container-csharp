using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiByValue(fqn: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigBackupWindowStart")]
    public class MdbMongodbClusterClusterConfigBackupWindowStart : yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigBackupWindowStart
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#hours MdbMongodbCluster#hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#minutes MdbMongodbCluster#minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minutes
        {
            get;
            set;
        }
    }
}
