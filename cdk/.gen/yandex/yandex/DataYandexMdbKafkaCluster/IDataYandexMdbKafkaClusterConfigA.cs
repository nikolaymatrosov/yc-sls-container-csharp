using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbKafkaClusterConfigA), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigA")]
    public interface IDataYandexMdbKafkaClusterConfigA
    {
        /// <summary>kafka block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#kafka DataYandexMdbKafkaCluster#kafka}
        /// </remarks>
        [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafka\"}")]
        yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafka Kafka
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#version DataYandexMdbKafkaCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#zones DataYandexMdbKafkaCluster#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Zones
        {
            get;
        }

        /// <summary>access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#access DataYandexMdbKafkaCluster#access}
        /// </remarks>
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigAccess? Access
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#assign_public_ip DataYandexMdbKafkaCluster#assign_public_ip}.</summary>
        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AssignPublicIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#brokers_count DataYandexMdbKafkaCluster#brokers_count}.</summary>
        [JsiiProperty(name: "brokersCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BrokersCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#schema_registry DataYandexMdbKafkaCluster#schema_registry}.</summary>
        [JsiiProperty(name: "schemaRegistry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SchemaRegistry
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#unmanaged_topics DataYandexMdbKafkaCluster#unmanaged_topics}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#zookeeper DataYandexMdbKafkaCluster#zookeeper}
        /// </remarks>
        [JsiiProperty(name: "zookeeper", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeper\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeper? Zookeeper
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbKafkaClusterConfigA), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigA")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kafka block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#kafka DataYandexMdbKafkaCluster#kafka}
            /// </remarks>
            [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafka\"}")]
            public yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafka Kafka
            {
                get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafka>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#version DataYandexMdbKafkaCluster#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#zones DataYandexMdbKafkaCluster#zones}.</summary>
            [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Zones
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#access DataYandexMdbKafkaCluster#access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigAccess\"}", isOptional: true)]
            public yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigAccess? Access
            {
                get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigAccess?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#assign_public_ip DataYandexMdbKafkaCluster#assign_public_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AssignPublicIp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#brokers_count DataYandexMdbKafkaCluster#brokers_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "brokersCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BrokersCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#schema_registry DataYandexMdbKafkaCluster#schema_registry}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schemaRegistry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SchemaRegistry
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#unmanaged_topics DataYandexMdbKafkaCluster#unmanaged_topics}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "unmanagedTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? UnmanagedTopics
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>zookeeper block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#zookeeper DataYandexMdbKafkaCluster#zookeeper}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zookeeper", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeper\"}", isOptional: true)]
            public yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeper? Zookeeper
            {
                get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeper?>();
            }
        }
    }
}
