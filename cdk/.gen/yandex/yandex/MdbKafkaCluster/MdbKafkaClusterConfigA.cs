using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigA")]
    public class MdbKafkaClusterConfigA : yandex.MdbKafkaCluster.IMdbKafkaClusterConfigA
    {
        /// <summary>kafka block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#kafka MdbKafkaCluster#kafka}
        /// </remarks>
        [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafka\"}")]
        public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafka Kafka
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#version MdbKafkaCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#zones MdbKafkaCluster#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Zones
        {
            get;
            set;
        }

        /// <summary>access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#access MdbKafkaCluster#access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigAccess\"}", isOptional: true)]
        public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigAccess? Access
        {
            get;
            set;
        }

        private object? _assignPublicIp;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#assign_public_ip MdbKafkaCluster#assign_public_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AssignPublicIp
        {
            get => _assignPublicIp;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _assignPublicIp = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#brokers_count MdbKafkaCluster#brokers_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "brokersCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BrokersCount
        {
            get;
            set;
        }

        private object? _schemaRegistry;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#schema_registry MdbKafkaCluster#schema_registry}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "schemaRegistry", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SchemaRegistry
        {
            get => _schemaRegistry;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schemaRegistry = value;
            }
        }

        private object? _unmanagedTopics;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#unmanaged_topics MdbKafkaCluster#unmanaged_topics}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unmanagedTopics", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UnmanagedTopics
        {
            get => _unmanagedTopics;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _unmanagedTopics = value;
            }
        }

        /// <summary>zookeeper block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#zookeeper MdbKafkaCluster#zookeeper}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zookeeper", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeper\"}", isOptional: true)]
        public yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeper? Zookeeper
        {
            get;
            set;
        }
    }
}
