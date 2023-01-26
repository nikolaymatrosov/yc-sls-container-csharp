using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaClusterConfigA), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigA")]
    public interface IMdbKafkaClusterConfigA
    {
        /// <summary>kafka block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#kafka MdbKafkaCluster#kafka}
        /// </remarks>
        [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafka\"}")]
        yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafka Kafka
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#version MdbKafkaCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#zones MdbKafkaCluster#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Zones
        {
            get;
        }

        /// <summary>access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#access MdbKafkaCluster#access}
        /// </remarks>
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbKafkaCluster.IMdbKafkaClusterConfigAccess? Access
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#assign_public_ip MdbKafkaCluster#assign_public_ip}.</summary>
        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AssignPublicIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#brokers_count MdbKafkaCluster#brokers_count}.</summary>
        [JsiiProperty(name: "brokersCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BrokersCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#schema_registry MdbKafkaCluster#schema_registry}.</summary>
        [JsiiProperty(name: "schemaRegistry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SchemaRegistry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#unmanaged_topics MdbKafkaCluster#unmanaged_topics}.</summary>
        [JsiiProperty(name: "unmanagedTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UnmanagedTopics
        {
            get
            {
                return null;
            }
        }

        /// <summary>zookeeper block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#zookeeper MdbKafkaCluster#zookeeper}
        /// </remarks>
        [JsiiProperty(name: "zookeeper", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeper\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeper? Zookeeper
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaClusterConfigA), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigA")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaCluster.IMdbKafkaClusterConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kafka block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#kafka MdbKafkaCluster#kafka}
            /// </remarks>
            [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafka\"}")]
            public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafka Kafka
            {
                get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafka>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#version MdbKafkaCluster#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#zones MdbKafkaCluster#zones}.</summary>
            [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Zones
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#access MdbKafkaCluster#access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigAccess\"}", isOptional: true)]
            public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigAccess? Access
            {
                get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigAccess?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#assign_public_ip MdbKafkaCluster#assign_public_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AssignPublicIp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#brokers_count MdbKafkaCluster#brokers_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "brokersCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BrokersCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#schema_registry MdbKafkaCluster#schema_registry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaRegistry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SchemaRegistry
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#unmanaged_topics MdbKafkaCluster#unmanaged_topics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unmanagedTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UnmanagedTopics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>zookeeper block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#zookeeper MdbKafkaCluster#zookeeper}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zookeeper", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeper\"}", isOptional: true)]
            public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeper? Zookeeper
            {
                get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeper?>();
            }
        }
    }
}
