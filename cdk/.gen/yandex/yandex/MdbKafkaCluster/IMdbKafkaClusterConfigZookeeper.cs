using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaClusterConfigZookeeper), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeper")]
    public interface IMdbKafkaClusterConfigZookeeper
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#resources MdbKafkaCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeperResources\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeperResources? Resources
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaClusterConfigZookeeper), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeper")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeper
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#resources MdbKafkaCluster#resources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeperResources\"}", isOptional: true)]
            public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeperResources? Resources
            {
                get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeperResources?>();
            }
        }
    }
}
