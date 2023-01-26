using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbPostgresqlDatabase
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbPostgresqlDatabaseExtension), fullyQualifiedName: "yandex.dataYandexMdbPostgresqlDatabase.DataYandexMdbPostgresqlDatabaseExtension")]
    public interface IDataYandexMdbPostgresqlDatabaseExtension
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_postgresql_database#name DataYandexMdbPostgresqlDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_postgresql_database#version DataYandexMdbPostgresqlDatabase#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbPostgresqlDatabaseExtension), fullyQualifiedName: "yandex.dataYandexMdbPostgresqlDatabase.DataYandexMdbPostgresqlDatabaseExtension")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbPostgresqlDatabase.IDataYandexMdbPostgresqlDatabaseExtension
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_postgresql_database#name DataYandexMdbPostgresqlDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_postgresql_database#version DataYandexMdbPostgresqlDatabase#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
