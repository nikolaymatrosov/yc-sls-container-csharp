using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    [JsiiByValue(fqn: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfig")]
    public class MdbPostgresqlClusterConfigPoolerConfig : yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPoolerConfig
    {
        private object? _poolDiscard;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#pool_discard MdbPostgresqlCluster#pool_discard}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolDiscard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PoolDiscard
        {
            get => _poolDiscard;
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
                _poolDiscard = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#pooling_mode MdbPostgresqlCluster#pooling_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "poolingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PoolingMode
        {
            get;
            set;
        }
    }
}
