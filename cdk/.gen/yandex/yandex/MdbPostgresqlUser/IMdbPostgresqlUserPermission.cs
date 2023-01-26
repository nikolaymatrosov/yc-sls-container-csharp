using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlUser
{
    [JsiiInterface(nativeType: typeof(IMdbPostgresqlUserPermission), fullyQualifiedName: "yandex.mdbPostgresqlUser.MdbPostgresqlUserPermission")]
    public interface IMdbPostgresqlUserPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_user#database_name MdbPostgresqlUser#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbPostgresqlUserPermission), fullyQualifiedName: "yandex.mdbPostgresqlUser.MdbPostgresqlUserPermission")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbPostgresqlUser.IMdbPostgresqlUserPermission
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_user#database_name MdbPostgresqlUser#database_name}.</summary>
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
