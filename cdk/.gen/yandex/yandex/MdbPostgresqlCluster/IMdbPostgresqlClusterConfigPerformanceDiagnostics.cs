using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    [JsiiInterface(nativeType: typeof(IMdbPostgresqlClusterConfigPerformanceDiagnostics), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPerformanceDiagnostics")]
    public interface IMdbPostgresqlClusterConfigPerformanceDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#sessions_sampling_interval MdbPostgresqlCluster#sessions_sampling_interval}.</summary>
        [JsiiProperty(name: "sessionsSamplingInterval", typeJson: "{\"primitive\":\"number\"}")]
        double SessionsSamplingInterval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#statements_sampling_interval MdbPostgresqlCluster#statements_sampling_interval}.</summary>
        [JsiiProperty(name: "statementsSamplingInterval", typeJson: "{\"primitive\":\"number\"}")]
        double StatementsSamplingInterval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#enabled MdbPostgresqlCluster#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbPostgresqlClusterConfigPerformanceDiagnostics), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPerformanceDiagnostics")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPerformanceDiagnostics
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#sessions_sampling_interval MdbPostgresqlCluster#sessions_sampling_interval}.</summary>
            [JsiiProperty(name: "sessionsSamplingInterval", typeJson: "{\"primitive\":\"number\"}")]
            public double SessionsSamplingInterval
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#statements_sampling_interval MdbPostgresqlCluster#statements_sampling_interval}.</summary>
            [JsiiProperty(name: "statementsSamplingInterval", typeJson: "{\"primitive\":\"number\"}")]
            public double StatementsSamplingInterval
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#enabled MdbPostgresqlCluster#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
