using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbKafkaClusterConfigZookeeper), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeper")]
    public interface IDataYandexMdbKafkaClusterConfigZookeeper
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#resources DataYandexMdbKafkaCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeperResources\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeperResources? Resources
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbKafkaClusterConfigZookeeper), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeper")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeper
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#resources DataYandexMdbKafkaCluster#resources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeperResources\"}", isOptional: true)]
            public yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeperResources? Resources
            {
                get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeperResources?>();
            }
        }
    }
}
