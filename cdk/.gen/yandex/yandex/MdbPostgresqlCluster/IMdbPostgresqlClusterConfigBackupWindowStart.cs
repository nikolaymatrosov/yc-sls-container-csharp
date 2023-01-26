using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    [JsiiInterface(nativeType: typeof(IMdbPostgresqlClusterConfigBackupWindowStart), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStart")]
    public interface IMdbPostgresqlClusterConfigBackupWindowStart
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#hours MdbPostgresqlCluster#hours}.</summary>
        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Hours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#minutes MdbPostgresqlCluster#minutes}.</summary>
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Minutes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbPostgresqlClusterConfigBackupWindowStart), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStart")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#hours MdbPostgresqlCluster#hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Hours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#minutes MdbPostgresqlCluster#minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Minutes
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
