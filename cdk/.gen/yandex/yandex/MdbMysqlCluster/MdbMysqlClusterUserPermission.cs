using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbMysqlCluster.MdbMysqlClusterUserPermission")]
    public class MdbMysqlClusterUserPermission : yandex.MdbMysqlCluster.IMdbMysqlClusterUserPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#database_name MdbMysqlCluster#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#roles MdbMysqlCluster#roles}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Roles
        {
            get;
            set;
        }
    }
}
