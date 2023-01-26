using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbGreenplumCluster
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbGreenplumClusterPoolerConfig), fullyQualifiedName: "yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterPoolerConfig")]
    public interface IDataYandexMdbGreenplumClusterPoolerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster#pool_client_idle_timeout DataYandexMdbGreenplumCluster#pool_client_idle_timeout}.</summary>
        [JsiiProperty(name: "poolClientIdleTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PoolClientIdleTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster#pooling_mode DataYandexMdbGreenplumCluster#pooling_mode}.</summary>
        [JsiiProperty(name: "poolingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PoolingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster#pool_size DataYandexMdbGreenplumCluster#pool_size}.</summary>
        [JsiiProperty(name: "poolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PoolSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbGreenplumClusterPoolerConfig), fullyQualifiedName: "yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterPoolerConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbGreenplumCluster.IDataYandexMdbGreenplumClusterPoolerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster#pool_client_idle_timeout DataYandexMdbGreenplumCluster#pool_client_idle_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolClientIdleTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PoolClientIdleTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster#pooling_mode DataYandexMdbGreenplumCluster#pooling_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PoolingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster#pool_size DataYandexMdbGreenplumCluster#pool_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "poolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PoolSize
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
