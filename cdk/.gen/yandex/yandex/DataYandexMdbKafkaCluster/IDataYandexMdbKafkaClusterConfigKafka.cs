using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbKafkaClusterConfigKafka), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafka")]
    public interface IDataYandexMdbKafkaClusterConfigKafka
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#resources DataYandexMdbKafkaCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResources\"}")]
        yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaResources Resources
        {
            get;
        }

        /// <summary>kafka_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#kafka_config DataYandexMdbKafkaCluster#kafka_config}
        /// </remarks>
        [JsiiProperty(name: "kafkaConfig", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaKafkaConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaKafkaConfig? KafkaConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbKafkaClusterConfigKafka), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafka")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafka
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#resources DataYandexMdbKafkaCluster#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResources\"}")]
            public yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaResources Resources
            {
                get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaResources>()!;
            }

            /// <summary>kafka_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#kafka_config DataYandexMdbKafkaCluster#kafka_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kafkaConfig", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaKafkaConfig\"}", isOptional: true)]
            public yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaKafkaConfig? KafkaConfig
            {
                get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaKafkaConfig?>();
            }
        }
    }
}
