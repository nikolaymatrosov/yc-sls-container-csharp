using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbMongodbCluster.MdbMongodbClusterDatabase")]
    public class MdbMongodbClusterDatabase : yandex.MdbMongodbCluster.IMdbMongodbClusterDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#name MdbMongodbCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
