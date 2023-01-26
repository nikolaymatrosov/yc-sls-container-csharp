using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiByValue(fqn: "yandex.mdbKafkaCluster.MdbKafkaClusterTopicTopicConfig")]
    public class MdbKafkaClusterTopicTopicConfig : yandex.MdbKafkaCluster.IMdbKafkaClusterTopicTopicConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#cleanup_policy MdbKafkaCluster#cleanup_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CleanupPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#compression_type MdbKafkaCluster#compression_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CompressionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#delete_retention_ms MdbKafkaCluster#delete_retention_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deleteRetentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeleteRetentionMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#file_delete_delay_ms MdbKafkaCluster#file_delete_delay_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileDeleteDelayMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FileDeleteDelayMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#flush_messages MdbKafkaCluster#flush_messages}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "flushMessages", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlushMessages
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#flush_ms MdbKafkaCluster#flush_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "flushMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FlushMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#max_message_bytes MdbKafkaCluster#max_message_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxMessageBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxMessageBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#min_compaction_lag_ms MdbKafkaCluster#min_compaction_lag_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minCompactionLagMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinCompactionLagMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#min_insync_replicas MdbKafkaCluster#min_insync_replicas}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minInsyncReplicas", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MinInsyncReplicas
        {
            get;
            set;
        }

        private object? _preallocate;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#preallocate MdbKafkaCluster#preallocate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preallocate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Preallocate
        {
            get => _preallocate;
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
                _preallocate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#retention_bytes MdbKafkaCluster#retention_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RetentionBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#retention_ms MdbKafkaCluster#retention_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retentionMs", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RetentionMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#segment_bytes MdbKafkaCluster#segment_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "segmentBytes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SegmentBytes
        {
            get;
            set;
        }
    }
}
