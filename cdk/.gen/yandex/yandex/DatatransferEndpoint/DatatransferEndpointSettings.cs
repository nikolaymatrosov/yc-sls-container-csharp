using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettings")]
    public class DatatransferEndpointSettings : yandex.DatatransferEndpoint.IDatatransferEndpointSettings
    {
        /// <summary>clickhouse_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#clickhouse_source DatatransferEndpoint#clickhouse_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clickhouseSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSource\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSource? ClickhouseSource
        {
            get;
            set;
        }

        /// <summary>clickhouse_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#clickhouse_target DatatransferEndpoint#clickhouse_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clickhouseTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTarget\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTarget? ClickhouseTarget
        {
            get;
            set;
        }

        /// <summary>mongo_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mongo_source DatatransferEndpoint#mongo_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mongoSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSource\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSource? MongoSource
        {
            get;
            set;
        }

        /// <summary>mongo_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mongo_target DatatransferEndpoint#mongo_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mongoTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTarget\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTarget? MongoTarget
        {
            get;
            set;
        }

        /// <summary>mysql_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mysql_source DatatransferEndpoint#mysql_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSource\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSource? MysqlSource
        {
            get;
            set;
        }

        /// <summary>mysql_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mysql_target DatatransferEndpoint#mysql_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mysqlTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTarget\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTarget? MysqlTarget
        {
            get;
            set;
        }

        /// <summary>postgres_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#postgres_source DatatransferEndpoint#postgres_source}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postgresSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSource\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSource? PostgresSource
        {
            get;
            set;
        }

        /// <summary>postgres_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#postgres_target DatatransferEndpoint#postgres_target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "postgresTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTarget\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTarget? PostgresTarget
        {
            get;
            set;
        }
    }
}
