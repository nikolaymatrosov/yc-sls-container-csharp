using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupPattern")]
    public class MdbClickhouseClusterClickhouseConfigGraphiteRollupPattern : yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollupPattern
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#function MdbClickhouseCluster#function}.</summary>
        [JsiiProperty(name: "function", typeJson: "{\"primitive\":\"string\"}")]
        public string Function
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#regexp MdbClickhouseCluster#regexp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regexp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Regexp
        {
            get;
            set;
        }

        private object? _retention;

        /// <summary>retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#retention MdbClickhouseCluster#retention}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retention", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Retention
        {
            get => _retention;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _retention = value;
            }
        }
    }
}
