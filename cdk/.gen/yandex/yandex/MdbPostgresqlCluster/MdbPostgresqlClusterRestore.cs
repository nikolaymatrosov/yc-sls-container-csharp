using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterRestore")]
    public class MdbPostgresqlClusterRestore : yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterRestore
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#backup_id MdbPostgresqlCluster#backup_id}.</summary>
        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
        public string BackupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#time MdbPostgresqlCluster#time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Time
        {
            get;
            set;
        }

        private object? _timeInclusive;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#time_inclusive MdbPostgresqlCluster#time_inclusive}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeInclusive", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TimeInclusive
        {
            get => _timeInclusive;
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
                _timeInclusive = value;
            }
        }
    }
}
