using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    [JsiiInterface(nativeType: typeof(IMdbPostgresqlClusterConfigA), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigA")]
    public interface IMdbPostgresqlClusterConfigA
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#resources MdbPostgresqlCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigResources\"}")]
        yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigResources Resources
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#version MdbPostgresqlCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#access MdbPostgresqlCluster#access}
        /// </remarks>
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigAccess? Access
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#autofailover MdbPostgresqlCluster#autofailover}.</summary>
        [JsiiProperty(name: "autofailover", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Autofailover
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#backup_retain_period_days MdbPostgresqlCluster#backup_retain_period_days}.</summary>
        [JsiiProperty(name: "backupRetainPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackupRetainPeriodDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>backup_window_start block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#backup_window_start MdbPostgresqlCluster#backup_window_start}
        /// </remarks>
        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStart\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart? BackupWindowStart
        {
            get
            {
                return null;
            }
        }

        /// <summary>performance_diagnostics block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#performance_diagnostics MdbPostgresqlCluster#performance_diagnostics}
        /// </remarks>
        [JsiiProperty(name: "performanceDiagnostics", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPerformanceDiagnostics\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPerformanceDiagnostics? PerformanceDiagnostics
        {
            get
            {
                return null;
            }
        }

        /// <summary>pooler_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#pooler_config MdbPostgresqlCluster#pooler_config}
        /// </remarks>
        [JsiiProperty(name: "poolerConfig", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPoolerConfig? PoolerConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#postgresql_config MdbPostgresqlCluster#postgresql_config}.</summary>
        [JsiiProperty(name: "postgresqlConfig", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? PostgresqlConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbPostgresqlClusterConfigA), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigA")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#resources MdbPostgresqlCluster#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigResources\"}")]
            public yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigResources Resources
            {
                get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigResources>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#version MdbPostgresqlCluster#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#access MdbPostgresqlCluster#access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigAccess\"}", isOptional: true)]
            public yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigAccess? Access
            {
                get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigAccess?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#autofailover MdbPostgresqlCluster#autofailover}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autofailover", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Autofailover
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#backup_retain_period_days MdbPostgresqlCluster#backup_retain_period_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backupRetainPeriodDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackupRetainPeriodDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>backup_window_start block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#backup_window_start MdbPostgresqlCluster#backup_window_start}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStart\"}", isOptional: true)]
            public yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart? BackupWindowStart
            {
                get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart?>();
            }

            /// <summary>performance_diagnostics block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#performance_diagnostics MdbPostgresqlCluster#performance_diagnostics}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "performanceDiagnostics", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPerformanceDiagnostics\"}", isOptional: true)]
            public yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPerformanceDiagnostics? PerformanceDiagnostics
            {
                get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPerformanceDiagnostics?>();
            }

            /// <summary>pooler_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#pooler_config MdbPostgresqlCluster#pooler_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "poolerConfig", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfig\"}", isOptional: true)]
            public yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPoolerConfig? PoolerConfig
            {
                get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPoolerConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#postgresql_config MdbPostgresqlCluster#postgresql_config}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "postgresqlConfig", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? PostgresqlConfig
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
