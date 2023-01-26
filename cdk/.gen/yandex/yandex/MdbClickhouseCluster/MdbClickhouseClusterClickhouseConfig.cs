using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfig")]
    public class MdbClickhouseClusterClickhouseConfig : yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#background_pool_size MdbClickhouseCluster#background_pool_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backgroundPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackgroundPoolSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#background_schedule_pool_size MdbClickhouseCluster#background_schedule_pool_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "backgroundSchedulePoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? BackgroundSchedulePoolSize
        {
            get;
            set;
        }

        private object? _compression;

        /// <summary>compression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#compression MdbClickhouseCluster#compression}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Compression
        {
            get => _compression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigCompression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigCompression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _compression = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#geobase_uri MdbClickhouseCluster#geobase_uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "geobaseUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GeobaseUri
        {
            get;
            set;
        }

        private object? _graphiteRollup;

        /// <summary>graphite_rollup block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#graphite_rollup MdbClickhouseCluster#graphite_rollup}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "graphiteRollup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GraphiteRollup
        {
            get => _graphiteRollup;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollup[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollup).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _graphiteRollup = value;
            }
        }

        /// <summary>kafka block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#kafka MdbClickhouseCluster#kafka}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafka\"}", isOptional: true)]
        public yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafka? Kafka
        {
            get;
            set;
        }

        private object? _kafkaTopic;

        /// <summary>kafka_topic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#kafka_topic MdbClickhouseCluster#kafka_topic}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kafkaTopic", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaTopic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? KafkaTopic
        {
            get => _kafkaTopic;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafkaTopic[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafkaTopic).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _kafkaTopic = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#keep_alive_timeout MdbClickhouseCluster#keep_alive_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keepAliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? KeepAliveTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#log_level MdbClickhouseCluster#log_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#mark_cache_size MdbClickhouseCluster#mark_cache_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "markCacheSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MarkCacheSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_concurrent_queries MdbClickhouseCluster#max_concurrent_queries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentQueries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentQueries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_connections MdbClickhouseCluster#max_connections}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConnections
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_partition_size_to_drop MdbClickhouseCluster#max_partition_size_to_drop}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxPartitionSizeToDrop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxPartitionSizeToDrop
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_table_size_to_drop MdbClickhouseCluster#max_table_size_to_drop}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTableSizeToDrop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTableSizeToDrop
        {
            get;
            set;
        }

        /// <summary>merge_tree block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#merge_tree MdbClickhouseCluster#merge_tree}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mergeTree", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTree\"}", isOptional: true)]
        public yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree? MergeTree
        {
            get;
            set;
        }

        private object? _metricLogEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#metric_log_enabled MdbClickhouseCluster#metric_log_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? MetricLogEnabled
        {
            get => _metricLogEnabled;
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
                _metricLogEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#metric_log_retention_size MdbClickhouseCluster#metric_log_retention_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MetricLogRetentionSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#metric_log_retention_time MdbClickhouseCluster#metric_log_retention_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MetricLogRetentionTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#part_log_retention_size MdbClickhouseCluster#part_log_retention_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PartLogRetentionSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#part_log_retention_time MdbClickhouseCluster#part_log_retention_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "partLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PartLogRetentionTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_log_retention_size MdbClickhouseCluster#query_log_retention_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? QueryLogRetentionSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_log_retention_time MdbClickhouseCluster#query_log_retention_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? QueryLogRetentionTime
        {
            get;
            set;
        }

        private object? _queryThreadLogEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_thread_log_enabled MdbClickhouseCluster#query_thread_log_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryThreadLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? QueryThreadLogEnabled
        {
            get => _queryThreadLogEnabled;
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
                _queryThreadLogEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_thread_log_retention_size MdbClickhouseCluster#query_thread_log_retention_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryThreadLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? QueryThreadLogRetentionSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_thread_log_retention_time MdbClickhouseCluster#query_thread_log_retention_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryThreadLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? QueryThreadLogRetentionTime
        {
            get;
            set;
        }

        /// <summary>rabbitmq block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#rabbitmq MdbClickhouseCluster#rabbitmq}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rabbitmq", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigRabbitmq\"}", isOptional: true)]
        public yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigRabbitmq? Rabbitmq
        {
            get;
            set;
        }

        private object? _textLogEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_enabled MdbClickhouseCluster#text_log_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "textLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TextLogEnabled
        {
            get => _textLogEnabled;
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
                _textLogEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_level MdbClickhouseCluster#text_log_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "textLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TextLogLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_retention_size MdbClickhouseCluster#text_log_retention_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "textLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TextLogRetentionSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_retention_time MdbClickhouseCluster#text_log_retention_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "textLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TextLogRetentionTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#timezone MdbClickhouseCluster#timezone}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Timezone
        {
            get;
            set;
        }

        private object? _traceLogEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#trace_log_enabled MdbClickhouseCluster#trace_log_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "traceLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TraceLogEnabled
        {
            get => _traceLogEnabled;
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
                _traceLogEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#trace_log_retention_size MdbClickhouseCluster#trace_log_retention_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "traceLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TraceLogRetentionSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#trace_log_retention_time MdbClickhouseCluster#trace_log_retention_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "traceLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TraceLogRetentionTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#uncompressed_cache_size MdbClickhouseCluster#uncompressed_cache_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uncompressedCacheSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? UncompressedCacheSize
        {
            get;
            set;
        }
    }
}
