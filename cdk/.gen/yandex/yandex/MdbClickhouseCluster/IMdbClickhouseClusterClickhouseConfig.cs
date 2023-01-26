using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterClickhouseConfig), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfig")]
    public interface IMdbClickhouseClusterClickhouseConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#background_pool_size MdbClickhouseCluster#background_pool_size}.</summary>
        [JsiiProperty(name: "backgroundPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackgroundPoolSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#background_schedule_pool_size MdbClickhouseCluster#background_schedule_pool_size}.</summary>
        [JsiiProperty(name: "backgroundSchedulePoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackgroundSchedulePoolSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>compression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#compression MdbClickhouseCluster#compression}
        /// </remarks>
        [JsiiProperty(name: "compression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Compression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#geobase_uri MdbClickhouseCluster#geobase_uri}.</summary>
        [JsiiProperty(name: "geobaseUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GeobaseUri
        {
            get
            {
                return null;
            }
        }

        /// <summary>graphite_rollup block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#graphite_rollup MdbClickhouseCluster#graphite_rollup}
        /// </remarks>
        [JsiiProperty(name: "graphiteRollup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GraphiteRollup
        {
            get
            {
                return null;
            }
        }

        /// <summary>kafka block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#kafka MdbClickhouseCluster#kafka}
        /// </remarks>
        [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafka\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafka? Kafka
        {
            get
            {
                return null;
            }
        }

        /// <summary>kafka_topic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#kafka_topic MdbClickhouseCluster#kafka_topic}
        /// </remarks>
        [JsiiProperty(name: "kafkaTopic", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaTopic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? KafkaTopic
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#keep_alive_timeout MdbClickhouseCluster#keep_alive_timeout}.</summary>
        [JsiiProperty(name: "keepAliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? KeepAliveTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#log_level MdbClickhouseCluster#log_level}.</summary>
        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#mark_cache_size MdbClickhouseCluster#mark_cache_size}.</summary>
        [JsiiProperty(name: "markCacheSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MarkCacheSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_concurrent_queries MdbClickhouseCluster#max_concurrent_queries}.</summary>
        [JsiiProperty(name: "maxConcurrentQueries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentQueries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_connections MdbClickhouseCluster#max_connections}.</summary>
        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConnections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_partition_size_to_drop MdbClickhouseCluster#max_partition_size_to_drop}.</summary>
        [JsiiProperty(name: "maxPartitionSizeToDrop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxPartitionSizeToDrop
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_table_size_to_drop MdbClickhouseCluster#max_table_size_to_drop}.</summary>
        [JsiiProperty(name: "maxTableSizeToDrop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxTableSizeToDrop
        {
            get
            {
                return null;
            }
        }

        /// <summary>merge_tree block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#merge_tree MdbClickhouseCluster#merge_tree}
        /// </remarks>
        [JsiiProperty(name: "mergeTree", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTree\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree? MergeTree
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#metric_log_enabled MdbClickhouseCluster#metric_log_enabled}.</summary>
        [JsiiProperty(name: "metricLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MetricLogEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#metric_log_retention_size MdbClickhouseCluster#metric_log_retention_size}.</summary>
        [JsiiProperty(name: "metricLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MetricLogRetentionSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#metric_log_retention_time MdbClickhouseCluster#metric_log_retention_time}.</summary>
        [JsiiProperty(name: "metricLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MetricLogRetentionTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#part_log_retention_size MdbClickhouseCluster#part_log_retention_size}.</summary>
        [JsiiProperty(name: "partLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PartLogRetentionSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#part_log_retention_time MdbClickhouseCluster#part_log_retention_time}.</summary>
        [JsiiProperty(name: "partLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PartLogRetentionTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_log_retention_size MdbClickhouseCluster#query_log_retention_size}.</summary>
        [JsiiProperty(name: "queryLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueryLogRetentionSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_log_retention_time MdbClickhouseCluster#query_log_retention_time}.</summary>
        [JsiiProperty(name: "queryLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueryLogRetentionTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_thread_log_enabled MdbClickhouseCluster#query_thread_log_enabled}.</summary>
        [JsiiProperty(name: "queryThreadLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? QueryThreadLogEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_thread_log_retention_size MdbClickhouseCluster#query_thread_log_retention_size}.</summary>
        [JsiiProperty(name: "queryThreadLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueryThreadLogRetentionSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_thread_log_retention_time MdbClickhouseCluster#query_thread_log_retention_time}.</summary>
        [JsiiProperty(name: "queryThreadLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueryThreadLogRetentionTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>rabbitmq block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#rabbitmq MdbClickhouseCluster#rabbitmq}
        /// </remarks>
        [JsiiProperty(name: "rabbitmq", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigRabbitmq\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigRabbitmq? Rabbitmq
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_enabled MdbClickhouseCluster#text_log_enabled}.</summary>
        [JsiiProperty(name: "textLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TextLogEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_level MdbClickhouseCluster#text_log_level}.</summary>
        [JsiiProperty(name: "textLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TextLogLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_retention_size MdbClickhouseCluster#text_log_retention_size}.</summary>
        [JsiiProperty(name: "textLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TextLogRetentionSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_retention_time MdbClickhouseCluster#text_log_retention_time}.</summary>
        [JsiiProperty(name: "textLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TextLogRetentionTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#timezone MdbClickhouseCluster#timezone}.</summary>
        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Timezone
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#trace_log_enabled MdbClickhouseCluster#trace_log_enabled}.</summary>
        [JsiiProperty(name: "traceLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TraceLogEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#trace_log_retention_size MdbClickhouseCluster#trace_log_retention_size}.</summary>
        [JsiiProperty(name: "traceLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TraceLogRetentionSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#trace_log_retention_time MdbClickhouseCluster#trace_log_retention_time}.</summary>
        [JsiiProperty(name: "traceLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TraceLogRetentionTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#uncompressed_cache_size MdbClickhouseCluster#uncompressed_cache_size}.</summary>
        [JsiiProperty(name: "uncompressedCacheSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? UncompressedCacheSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterClickhouseConfig), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#background_pool_size MdbClickhouseCluster#background_pool_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backgroundPoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackgroundPoolSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#background_schedule_pool_size MdbClickhouseCluster#background_schedule_pool_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "backgroundSchedulePoolSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackgroundSchedulePoolSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>compression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#compression MdbClickhouseCluster#compression}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Compression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#geobase_uri MdbClickhouseCluster#geobase_uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "geobaseUri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GeobaseUri
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>graphite_rollup block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#graphite_rollup MdbClickhouseCluster#graphite_rollup}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "graphiteRollup", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GraphiteRollup
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>kafka block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#kafka MdbClickhouseCluster#kafka}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafka\"}", isOptional: true)]
            public yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafka? Kafka
            {
                get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafka?>();
            }

            /// <summary>kafka_topic block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#kafka_topic MdbClickhouseCluster#kafka_topic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kafkaTopic", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaTopic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? KafkaTopic
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#keep_alive_timeout MdbClickhouseCluster#keep_alive_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keepAliveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? KeepAliveTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#log_level MdbClickhouseCluster#log_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#mark_cache_size MdbClickhouseCluster#mark_cache_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "markCacheSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MarkCacheSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_concurrent_queries MdbClickhouseCluster#max_concurrent_queries}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentQueries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentQueries
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_connections MdbClickhouseCluster#max_connections}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConnections
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_partition_size_to_drop MdbClickhouseCluster#max_partition_size_to_drop}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxPartitionSizeToDrop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxPartitionSizeToDrop
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_table_size_to_drop MdbClickhouseCluster#max_table_size_to_drop}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxTableSizeToDrop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxTableSizeToDrop
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>merge_tree block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#merge_tree MdbClickhouseCluster#merge_tree}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mergeTree", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTree\"}", isOptional: true)]
            public yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree? MergeTree
            {
                get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#metric_log_enabled MdbClickhouseCluster#metric_log_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? MetricLogEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#metric_log_retention_size MdbClickhouseCluster#metric_log_retention_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MetricLogRetentionSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#metric_log_retention_time MdbClickhouseCluster#metric_log_retention_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metricLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MetricLogRetentionTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#part_log_retention_size MdbClickhouseCluster#part_log_retention_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PartLogRetentionSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#part_log_retention_time MdbClickhouseCluster#part_log_retention_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PartLogRetentionTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_log_retention_size MdbClickhouseCluster#query_log_retention_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueryLogRetentionSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_log_retention_time MdbClickhouseCluster#query_log_retention_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueryLogRetentionTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_thread_log_enabled MdbClickhouseCluster#query_thread_log_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryThreadLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? QueryThreadLogEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_thread_log_retention_size MdbClickhouseCluster#query_thread_log_retention_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryThreadLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueryThreadLogRetentionSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#query_thread_log_retention_time MdbClickhouseCluster#query_thread_log_retention_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryThreadLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueryThreadLogRetentionTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>rabbitmq block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#rabbitmq MdbClickhouseCluster#rabbitmq}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rabbitmq", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigRabbitmq\"}", isOptional: true)]
            public yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigRabbitmq? Rabbitmq
            {
                get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigRabbitmq?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_enabled MdbClickhouseCluster#text_log_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "textLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TextLogEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_level MdbClickhouseCluster#text_log_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "textLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TextLogLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_retention_size MdbClickhouseCluster#text_log_retention_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "textLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TextLogRetentionSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#text_log_retention_time MdbClickhouseCluster#text_log_retention_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "textLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TextLogRetentionTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#timezone MdbClickhouseCluster#timezone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Timezone
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#trace_log_enabled MdbClickhouseCluster#trace_log_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "traceLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? TraceLogEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#trace_log_retention_size MdbClickhouseCluster#trace_log_retention_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "traceLogRetentionSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TraceLogRetentionSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#trace_log_retention_time MdbClickhouseCluster#trace_log_retention_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "traceLogRetentionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TraceLogRetentionTime
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#uncompressed_cache_size MdbClickhouseCluster#uncompressed_cache_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uncompressedCacheSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? UncompressedCacheSize
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
