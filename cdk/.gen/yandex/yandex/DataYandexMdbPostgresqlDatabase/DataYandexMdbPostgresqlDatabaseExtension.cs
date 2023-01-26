using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbPostgresqlDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataYandexMdbPostgresqlDatabase.DataYandexMdbPostgresqlDatabaseExtension")]
    public class DataYandexMdbPostgresqlDatabaseExtension : yandex.DataYandexMdbPostgresqlDatabase.IDataYandexMdbPostgresqlDatabaseExtension
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_postgresql_database#name DataYandexMdbPostgresqlDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_postgresql_database#version DataYandexMdbPostgresqlDatabase#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
