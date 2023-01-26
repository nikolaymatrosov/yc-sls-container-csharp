using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaTopic
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaTopicTopicConfig), fullyQualifiedName: "yandex.mdbKafkaTopic.MdbKafkaTopicTopicConfig")]
    public interface IMdbKafkaTopicTopicConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#cleanup_policy MdbKafkaTopic#cleanup_policy}.</summary>
        [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CleanupPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#compression_type MdbKafkaTopic#compression_type}.</summary>
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompressionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#delete_retention_ms MdbKafkaTopic#delete_retention_ms}.</summary>
        [JsiiProperty(name: "deleteRetentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeleteRetentionMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#file_delete_delay_ms MdbKafkaTopic#file_delete_delay_ms}.</summary>
        [JsiiProperty(name: "fileDeleteDelayMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FileDeleteDelayMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#flush_messages MdbKafkaTopic#flush_messages}.</summary>
        [JsiiProperty(name: "flushMessages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FlushMessages
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#flush_ms MdbKafkaTopic#flush_ms}.</summary>
        [JsiiProperty(name: "flushMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FlushMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#max_message_bytes MdbKafkaTopic#max_message_bytes}.</summary>
        [JsiiProperty(name: "maxMessageBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxMessageBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#min_compaction_lag_ms MdbKafkaTopic#min_compaction_lag_ms}.</summary>
        [JsiiProperty(name: "minCompactionLagMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinCompactionLagMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#min_insync_replicas MdbKafkaTopic#min_insync_replicas}.</summary>
        [JsiiProperty(name: "minInsyncReplicas", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MinInsyncReplicas
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#preallocate MdbKafkaTopic#preallocate}.</summary>
        [JsiiProperty(name: "preallocate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Preallocate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#retention_bytes MdbKafkaTopic#retention_bytes}.</summary>
        [JsiiProperty(name: "retentionBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RetentionBytes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#retention_ms MdbKafkaTopic#retention_ms}.</summary>
        [JsiiProperty(name: "retentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RetentionMs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#segment_bytes MdbKafkaTopic#segment_bytes}.</summary>
        [JsiiProperty(name: "segmentBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SegmentBytes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaTopicTopicConfig), fullyQualifiedName: "yandex.mdbKafkaTopic.MdbKafkaTopicTopicConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaTopic.IMdbKafkaTopicTopicConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#cleanup_policy MdbKafkaTopic#cleanup_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CleanupPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#compression_type MdbKafkaTopic#compression_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompressionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#delete_retention_ms MdbKafkaTopic#delete_retention_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deleteRetentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeleteRetentionMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#file_delete_delay_ms MdbKafkaTopic#file_delete_delay_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileDeleteDelayMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FileDeleteDelayMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#flush_messages MdbKafkaTopic#flush_messages}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "flushMessages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlushMessages
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#flush_ms MdbKafkaTopic#flush_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "flushMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FlushMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#max_message_bytes MdbKafkaTopic#max_message_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxMessageBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxMessageBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#min_compaction_lag_ms MdbKafkaTopic#min_compaction_lag_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minCompactionLagMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinCompactionLagMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#min_insync_replicas MdbKafkaTopic#min_insync_replicas}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minInsyncReplicas", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MinInsyncReplicas
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#preallocate MdbKafkaTopic#preallocate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preallocate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Preallocate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#retention_bytes MdbKafkaTopic#retention_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RetentionBytes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#retention_ms MdbKafkaTopic#retention_ms}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RetentionMs
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic#segment_bytes MdbKafkaTopic#segment_bytes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "segmentBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SegmentBytes
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
