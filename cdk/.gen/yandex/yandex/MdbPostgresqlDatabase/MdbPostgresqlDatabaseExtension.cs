using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbPostgresqlDatabase.MdbPostgresqlDatabaseExtension")]
    public class MdbPostgresqlDatabaseExtension : yandex.MdbPostgresqlDatabase.IMdbPostgresqlDatabaseExtension
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_database#name MdbPostgresqlDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_database#version MdbPostgresqlDatabase#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
