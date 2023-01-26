using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollup")]
    public class MdbClickhouseClusterClickhouseConfigGraphiteRollup : yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#name MdbClickhouseCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object? _pattern;

        /// <summary>pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#pattern MdbClickhouseCluster#pattern}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pattern", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupPattern\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Pattern
        {
            get => _pattern;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollupPattern[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollupPattern).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pattern = value;
            }
        }
    }
}
