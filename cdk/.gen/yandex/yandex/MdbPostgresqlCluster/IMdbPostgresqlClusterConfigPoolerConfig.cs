using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    [JsiiInterface(nativeType: typeof(IMdbPostgresqlClusterConfigPoolerConfig), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfig")]
    public interface IMdbPostgresqlClusterConfigPoolerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#pool_discard MdbPostgresqlCluster#pool_discard}.</summary>
        [JsiiProperty(name: "poolDiscard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PoolDiscard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#pooling_mode MdbPostgresqlCluster#pooling_mode}.</summary>
        [JsiiProperty(name: "poolingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PoolingMode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbPostgresqlClusterConfigPoolerConfig), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPoolerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#pool_discard MdbPostgresqlCluster#pool_discard}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolDiscard", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PoolDiscard
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#pooling_mode MdbPostgresqlCluster#pooling_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PoolingMode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
