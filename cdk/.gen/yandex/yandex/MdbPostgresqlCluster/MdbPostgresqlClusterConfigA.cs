using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigA")]
    public class MdbPostgresqlClusterConfigA : yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigA
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#resources MdbPostgresqlCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigResources\"}")]
        public yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigResources Resources
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#version MdbPostgresqlCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#access MdbPostgresqlCluster#access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigAccess\"}", isOptional: true)]
        public yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigAccess? Access
        {
            get;
            set;
        }

        private object? _autofailover;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#autofailover MdbPostgresqlCluster#autofailover}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autofailover", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Autofailover
        {
            get => _autofailover;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _autofailover = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#backup_retain_period_days MdbPostgresqlCluster#backup_retain_period_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backupRetainPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackupRetainPeriodDays
        {
            get;
            set;
        }

        /// <summary>backup_window_start block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#backup_window_start MdbPostgresqlCluster#backup_window_start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStart\"}", isOptional: true)]
        public yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart? BackupWindowStart
        {
            get;
            set;
        }

        /// <summary>performance_diagnostics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#performance_diagnostics MdbPostgresqlCluster#performance_diagnostics}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "performanceDiagnostics", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPerformanceDiagnostics\"}", isOptional: true)]
        public yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPerformanceDiagnostics? PerformanceDiagnostics
        {
            get;
            set;
        }

        /// <summary>pooler_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#pooler_config MdbPostgresqlCluster#pooler_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "poolerConfig", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfig\"}", isOptional: true)]
        public yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPoolerConfig? PoolerConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#postgresql_config MdbPostgresqlCluster#postgresql_config}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "postgresqlConfig", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? PostgresqlConfig
        {
            get;
            set;
        }
    }
}
