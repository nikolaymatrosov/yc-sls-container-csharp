using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMongodbCluster
{
    [JsiiByValue(fqn: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigBackupWindowStart")]
    public class DataYandexMdbMongodbClusterClusterConfigBackupWindowStart : yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigBackupWindowStart
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#hours DataYandexMdbMongodbCluster#hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#minutes DataYandexMdbMongodbCluster#minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minutes
        {
            get;
            set;
        }
    }
}
