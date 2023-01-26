using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbMysqlCluster.MdbMysqlClusterPerformanceDiagnostics")]
    public class MdbMysqlClusterPerformanceDiagnostics : yandex.MdbMysqlCluster.IMdbMysqlClusterPerformanceDiagnostics
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#sessions_sampling_interval MdbMysqlCluster#sessions_sampling_interval}.</summary>
        [JsiiProperty(name: "sessionsSamplingInterval", typeJson: "{\"primitive\":\"number\"}")]
        public double SessionsSamplingInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#statements_sampling_interval MdbMysqlCluster#statements_sampling_interval}.</summary>
        [JsiiProperty(name: "statementsSamplingInterval", typeJson: "{\"primitive\":\"number\"}")]
        public double StatementsSamplingInterval
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#enabled MdbMysqlCluster#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
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
                _enabled = value;
            }
        }
    }
}
