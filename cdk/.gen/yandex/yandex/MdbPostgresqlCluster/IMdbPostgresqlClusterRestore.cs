using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    [JsiiInterface(nativeType: typeof(IMdbPostgresqlClusterRestore), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterRestore")]
    public interface IMdbPostgresqlClusterRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#backup_id MdbPostgresqlCluster#backup_id}.</summary>
        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
        string BackupId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#time MdbPostgresqlCluster#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Time
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#time_inclusive MdbPostgresqlCluster#time_inclusive}.</summary>
        [JsiiProperty(name: "timeInclusive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TimeInclusive
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbPostgresqlClusterRestore), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterRestore")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterRestore
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#backup_id MdbPostgresqlCluster#backup_id}.</summary>
            [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
            public string BackupId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#time MdbPostgresqlCluster#time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Time
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#time_inclusive MdbPostgresqlCluster#time_inclusive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeInclusive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TimeInclusive
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
