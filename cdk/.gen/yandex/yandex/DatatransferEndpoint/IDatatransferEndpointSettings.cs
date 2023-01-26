using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettings), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettings")]
    public interface IDatatransferEndpointSettings
    {
        /// <summary>clickhouse_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#clickhouse_source DatatransferEndpoint#clickhouse_source}
        /// </remarks>
        [JsiiProperty(name: "clickhouseSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSource? ClickhouseSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>clickhouse_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#clickhouse_target DatatransferEndpoint#clickhouse_target}
        /// </remarks>
        [JsiiProperty(name: "clickhouseTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTarget? ClickhouseTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>mongo_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mongo_source DatatransferEndpoint#mongo_source}
        /// </remarks>
        [JsiiProperty(name: "mongoSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSource? MongoSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>mongo_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mongo_target DatatransferEndpoint#mongo_target}
        /// </remarks>
        [JsiiProperty(name: "mongoTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTarget? MongoTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>mysql_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mysql_source DatatransferEndpoint#mysql_source}
        /// </remarks>
        [JsiiProperty(name: "mysqlSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSource? MysqlSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>mysql_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mysql_target DatatransferEndpoint#mysql_target}
        /// </remarks>
        [JsiiProperty(name: "mysqlTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTarget? MysqlTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>postgres_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#postgres_source DatatransferEndpoint#postgres_source}
        /// </remarks>
        [JsiiProperty(name: "postgresSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSource? PostgresSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>postgres_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#postgres_target DatatransferEndpoint#postgres_target}
        /// </remarks>
        [JsiiProperty(name: "postgresTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTarget\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTarget? PostgresTarget
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettings), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettings")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>clickhouse_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#clickhouse_source DatatransferEndpoint#clickhouse_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clickhouseSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSource\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSource? ClickhouseSource
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSource?>();
            }

            /// <summary>clickhouse_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#clickhouse_target DatatransferEndpoint#clickhouse_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clickhouseTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTarget\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTarget? ClickhouseTarget
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTarget?>();
            }

            /// <summary>mongo_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mongo_source DatatransferEndpoint#mongo_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mongoSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSource\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSource? MongoSource
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSource?>();
            }

            /// <summary>mongo_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mongo_target DatatransferEndpoint#mongo_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mongoTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTarget\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTarget? MongoTarget
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTarget?>();
            }

            /// <summary>mysql_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mysql_source DatatransferEndpoint#mysql_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mysqlSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSource\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSource? MysqlSource
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSource?>();
            }

            /// <summary>mysql_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mysql_target DatatransferEndpoint#mysql_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mysqlTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTarget\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTarget? MysqlTarget
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTarget?>();
            }

            /// <summary>postgres_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#postgres_source DatatransferEndpoint#postgres_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postgresSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSource\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSource? PostgresSource
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSource?>();
            }

            /// <summary>postgres_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#postgres_target DatatransferEndpoint#postgres_target}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "postgresTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTarget\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTarget? PostgresTarget
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTarget?>();
            }
        }
    }
}
