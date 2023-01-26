using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaClusterTopic), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterTopic")]
    public interface IMdbKafkaClusterTopic
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#name MdbKafkaCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#partitions MdbKafkaCluster#partitions}.</summary>
        [JsiiProperty(name: "partitions", typeJson: "{\"primitive\":\"number\"}")]
        double Partitions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#replication_factor MdbKafkaCluster#replication_factor}.</summary>
        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        double ReplicationFactor
        {
            get;
        }

        /// <summary>topic_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#topic_config MdbKafkaCluster#topic_config}
        /// </remarks>
        [JsiiProperty(name: "topicConfig", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterTopicTopicConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbKafkaCluster.IMdbKafkaClusterTopicTopicConfig? TopicConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaClusterTopic), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterTopic")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaCluster.IMdbKafkaClusterTopic
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#name MdbKafkaCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#partitions MdbKafkaCluster#partitions}.</summary>
            [JsiiProperty(name: "partitions", typeJson: "{\"primitive\":\"number\"}")]
            public double Partitions
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#replication_factor MdbKafkaCluster#replication_factor}.</summary>
            [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
            public double ReplicationFactor
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>topic_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#topic_config MdbKafkaCluster#topic_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topicConfig", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterTopicTopicConfig\"}", isOptional: true)]
            public yandex.MdbKafkaCluster.IMdbKafkaClusterTopicTopicConfig? TopicConfig
            {
                get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterTopicTopicConfig?>();
            }
        }
    }
}
