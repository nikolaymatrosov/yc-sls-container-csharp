using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterClickhouseConfigGraphiteRollupPattern), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupPattern")]
    public interface IMdbClickhouseClusterClickhouseConfigGraphiteRollupPattern
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#function MdbClickhouseCluster#function}.</summary>
        [JsiiProperty(name: "function", typeJson: "{\"primitive\":\"string\"}")]
        string Function
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#regexp MdbClickhouseCluster#regexp}.</summary>
        [JsiiProperty(name: "regexp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Regexp
        {
            get
            {
                return null;
            }
        }

        /// <summary>retention block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#retention MdbClickhouseCluster#retention}
        /// </remarks>
        [JsiiProperty(name: "retention", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Retention
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterClickhouseConfigGraphiteRollupPattern), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupPattern")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollupPattern
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#function MdbClickhouseCluster#function}.</summary>
            [JsiiProperty(name: "function", typeJson: "{\"primitive\":\"string\"}")]
            public string Function
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#regexp MdbClickhouseCluster#regexp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regexp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Regexp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>retention block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#retention MdbClickhouseCluster#retention}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retention", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupPatternRetention\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Retention
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
