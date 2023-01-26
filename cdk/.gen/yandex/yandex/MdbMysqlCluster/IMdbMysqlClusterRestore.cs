using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    [JsiiInterface(nativeType: typeof(IMdbMysqlClusterRestore), fullyQualifiedName: "yandex.mdbMysqlCluster.MdbMysqlClusterRestore")]
    public interface IMdbMysqlClusterRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#backup_id MdbMysqlCluster#backup_id}.</summary>
        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
        string BackupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#time MdbMysqlCluster#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Time
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbMysqlClusterRestore), fullyQualifiedName: "yandex.mdbMysqlCluster.MdbMysqlClusterRestore")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbMysqlCluster.IMdbMysqlClusterRestore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#backup_id MdbMysqlCluster#backup_id}.</summary>
            [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
            public string BackupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#time MdbMysqlCluster#time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Time
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
