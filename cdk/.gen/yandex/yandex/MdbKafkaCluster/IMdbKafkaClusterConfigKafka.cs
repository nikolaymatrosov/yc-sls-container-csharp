using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaClusterConfigKafka), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafka")]
    public interface IMdbKafkaClusterConfigKafka
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#resources MdbKafkaCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaResources\"}")]
        yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaResources Resources
        {
            get;
        }

        /// <summary>kafka_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#kafka_config MdbKafkaCluster#kafka_config}
        /// </remarks>
        [JsiiProperty(name: "kafkaConfig", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaKafkaConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaKafkaConfig? KafkaConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaClusterConfigKafka), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafka")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafka
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#resources MdbKafkaCluster#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaResources\"}")]
            public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaResources Resources
            {
                get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaResources>()!;
            }

            /// <summary>kafka_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#kafka_config MdbKafkaCluster#kafka_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kafkaConfig", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaKafkaConfig\"}", isOptional: true)]
            public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaKafkaConfig? KafkaConfig
            {
                get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaKafkaConfig?>();
            }
        }
    }
}
