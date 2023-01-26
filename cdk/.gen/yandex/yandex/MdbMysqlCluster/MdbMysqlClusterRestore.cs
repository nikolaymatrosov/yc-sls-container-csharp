using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbMysqlCluster.MdbMysqlClusterRestore")]
    public class MdbMysqlClusterRestore : yandex.MdbMysqlCluster.IMdbMysqlClusterRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#backup_id MdbMysqlCluster#backup_id}.</summary>
        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
        public string BackupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#time MdbMysqlCluster#time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Time
        {
            get;
            set;
        }
    }
}
