using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaClusterConfigKafkaKafkaConfig), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaKafkaConfig")]
    public interface IMdbKafkaClusterConfigKafkaKafkaConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#auto_create_topics_enable MdbKafkaCluster#auto_create_topics_enable}.</summary>
        [JsiiProperty(name: "autoCreateTopicsEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoCreateTopicsEnable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#compression_type MdbKafkaCluster#compression_type}.</summary>
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompressionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#default_replication_factor MdbKafkaCluster#default_replication_factor}.</summary>
        [JsiiProperty(name: "defaultReplicationFactor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultReplicationFactor
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_flush_interval_messages MdbKafkaCluster#log_flush_interval_messages}.</summary>
        [JsiiProperty(name: "logFlushIntervalMessages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogFlushIntervalMessages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_flush_interval_ms MdbKafkaCluster#log_flush_interval_ms}.</summary>
        [JsiiProperty(name: "logFlushIntervalMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogFlushIntervalMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_flush_scheduler_interval_ms MdbKafkaCluster#log_flush_scheduler_interval_ms}.</summary>
        [JsiiProperty(name: "logFlushSchedulerIntervalMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogFlushSchedulerIntervalMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_preallocate MdbKafkaCluster#log_preallocate}.</summary>
        [JsiiProperty(name: "logPreallocate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogPreallocate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_retention_bytes MdbKafkaCluster#log_retention_bytes}.</summary>
        [JsiiProperty(name: "logRetentionBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogRetentionBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_retention_hours MdbKafkaCluster#log_retention_hours}.</summary>
        [JsiiProperty(name: "logRetentionHours", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogRetentionHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_retention_minutes MdbKafkaCluster#log_retention_minutes}.</summary>
        [JsiiProperty(name: "logRetentionMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogRetentionMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_retention_ms MdbKafkaCluster#log_retention_ms}.</summary>
        [JsiiProperty(name: "logRetentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogRetentionMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_segment_bytes MdbKafkaCluster#log_segment_bytes}.</summary>
        [JsiiProperty(name: "logSegmentBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogSegmentBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#message_max_bytes MdbKafkaCluster#message_max_bytes}.</summary>
        [JsiiProperty(name: "messageMaxBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MessageMaxBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#num_partitions MdbKafkaCluster#num_partitions}.</summary>
        [JsiiProperty(name: "numPartitions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NumPartitions
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#offsets_retention_minutes MdbKafkaCluster#offsets_retention_minutes}.</summary>
        [JsiiProperty(name: "offsetsRetentionMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OffsetsRetentionMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#replica_fetch_max_bytes MdbKafkaCluster#replica_fetch_max_bytes}.</summary>
        [JsiiProperty(name: "replicaFetchMaxBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicaFetchMaxBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#sasl_enabled_mechanisms MdbKafkaCluster#sasl_enabled_mechanisms}.</summary>
        [JsiiProperty(name: "saslEnabledMechanisms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SaslEnabledMechanisms
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#socket_receive_buffer_bytes MdbKafkaCluster#socket_receive_buffer_bytes}.</summary>
        [JsiiProperty(name: "socketReceiveBufferBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SocketReceiveBufferBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#socket_send_buffer_bytes MdbKafkaCluster#socket_send_buffer_bytes}.</summary>
        [JsiiProperty(name: "socketSendBufferBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SocketSendBufferBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#ssl_cipher_suites MdbKafkaCluster#ssl_cipher_suites}.</summary>
        [JsiiProperty(name: "sslCipherSuites", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SslCipherSuites
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaClusterConfigKafkaKafkaConfig), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaKafkaConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaKafkaConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#auto_create_topics_enable MdbKafkaCluster#auto_create_topics_enable}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoCreateTopicsEnable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoCreateTopicsEnable
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#compression_type MdbKafkaCluster#compression_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#default_replication_factor MdbKafkaCluster#default_replication_factor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultReplicationFactor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultReplicationFactor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_flush_interval_messages MdbKafkaCluster#log_flush_interval_messages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logFlushIntervalMessages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogFlushIntervalMessages
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_flush_interval_ms MdbKafkaCluster#log_flush_interval_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logFlushIntervalMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogFlushIntervalMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_flush_scheduler_interval_ms MdbKafkaCluster#log_flush_scheduler_interval_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logFlushSchedulerIntervalMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogFlushSchedulerIntervalMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_preallocate MdbKafkaCluster#log_preallocate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logPreallocate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? LogPreallocate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_retention_bytes MdbKafkaCluster#log_retention_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logRetentionBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogRetentionBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_retention_hours MdbKafkaCluster#log_retention_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logRetentionHours", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogRetentionHours
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_retention_minutes MdbKafkaCluster#log_retention_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logRetentionMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogRetentionMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_retention_ms MdbKafkaCluster#log_retention_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logRetentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogRetentionMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#log_segment_bytes MdbKafkaCluster#log_segment_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logSegmentBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogSegmentBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#message_max_bytes MdbKafkaCluster#message_max_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "messageMaxBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MessageMaxBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#num_partitions MdbKafkaCluster#num_partitions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numPartitions", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NumPartitions
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#offsets_retention_minutes MdbKafkaCluster#offsets_retention_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "offsetsRetentionMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OffsetsRetentionMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#replica_fetch_max_bytes MdbKafkaCluster#replica_fetch_max_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicaFetchMaxBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicaFetchMaxBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#sasl_enabled_mechanisms MdbKafkaCluster#sasl_enabled_mechanisms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saslEnabledMechanisms", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SaslEnabledMechanisms
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#socket_receive_buffer_bytes MdbKafkaCluster#socket_receive_buffer_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "socketReceiveBufferBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SocketReceiveBufferBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#socket_send_buffer_bytes MdbKafkaCluster#socket_send_buffer_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "socketSendBufferBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SocketSendBufferBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#ssl_cipher_suites MdbKafkaCluster#ssl_cipher_suites}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sslCipherSuites", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SslCipherSuites
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
