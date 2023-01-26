using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    [JsiiByValue(fqn: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaKafkaConfig")]
    public class DataYandexMdbKafkaClusterConfigKafkaKafkaConfig : yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaKafkaConfig
    {
        private object? _autoCreateTopicsEnable;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#auto_create_topics_enable DataYandexMdbKafkaCluster#auto_create_topics_enable}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoCreateTopicsEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoCreateTopicsEnable
        {
            get => _autoCreateTopicsEnable;
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
                _autoCreateTopicsEnable = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#compression_type DataYandexMdbKafkaCluster#compression_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#default_replication_factor DataYandexMdbKafkaCluster#default_replication_factor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultReplicationFactor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultReplicationFactor
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#log_flush_interval_messages DataYandexMdbKafkaCluster#log_flush_interval_messages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logFlushIntervalMessages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogFlushIntervalMessages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#log_flush_interval_ms DataYandexMdbKafkaCluster#log_flush_interval_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logFlushIntervalMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogFlushIntervalMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#log_flush_scheduler_interval_ms DataYandexMdbKafkaCluster#log_flush_scheduler_interval_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logFlushSchedulerIntervalMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogFlushSchedulerIntervalMs
        {
            get;
            set;
        }

        private object? _logPreallocate;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#log_preallocate DataYandexMdbKafkaCluster#log_preallocate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logPreallocate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? LogPreallocate
        {
            get => _logPreallocate;
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
                _logPreallocate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#log_retention_bytes DataYandexMdbKafkaCluster#log_retention_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logRetentionBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogRetentionBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#log_retention_hours DataYandexMdbKafkaCluster#log_retention_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logRetentionHours", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogRetentionHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#log_retention_minutes DataYandexMdbKafkaCluster#log_retention_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logRetentionMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogRetentionMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#log_retention_ms DataYandexMdbKafkaCluster#log_retention_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logRetentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogRetentionMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#log_segment_bytes DataYandexMdbKafkaCluster#log_segment_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logSegmentBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogSegmentBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#message_max_bytes DataYandexMdbKafkaCluster#message_max_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageMaxBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageMaxBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#num_partitions DataYandexMdbKafkaCluster#num_partitions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numPartitions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NumPartitions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#offsets_retention_minutes DataYandexMdbKafkaCluster#offsets_retention_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "offsetsRetentionMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OffsetsRetentionMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#replica_fetch_max_bytes DataYandexMdbKafkaCluster#replica_fetch_max_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicaFetchMaxBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicaFetchMaxBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#sasl_enabled_mechanisms DataYandexMdbKafkaCluster#sasl_enabled_mechanisms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "saslEnabledMechanisms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SaslEnabledMechanisms
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#socket_receive_buffer_bytes DataYandexMdbKafkaCluster#socket_receive_buffer_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "socketReceiveBufferBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SocketReceiveBufferBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#socket_send_buffer_bytes DataYandexMdbKafkaCluster#socket_send_buffer_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "socketSendBufferBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SocketSendBufferBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#ssl_cipher_suites DataYandexMdbKafkaCluster#ssl_cipher_suites}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sslCipherSuites", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SslCipherSuites
        {
            get;
            set;
        }
    }
}
