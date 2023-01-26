using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiByValue(fqn: "yandex.mdbClickhouseCluster.MdbClickhouseClusterUserSettings")]
    public class MdbClickhouseClusterUserSettings : yandex.MdbClickhouseCluster.IMdbClickhouseClusterUserSettings
    {
        private object? _addHttpCorsHeader;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#add_http_cors_header MdbClickhouseCluster#add_http_cors_header}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "addHttpCorsHeader", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AddHttpCorsHeader
        {
            get => _addHttpCorsHeader;
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
                _addHttpCorsHeader = value;
            }
        }

        private object? _allowDdl;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#allow_ddl MdbClickhouseCluster#allow_ddl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowDdl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowDdl
        {
            get => _allowDdl;
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
                _allowDdl = value;
            }
        }

        private object? _compile;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#compile MdbClickhouseCluster#compile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Compile
        {
            get => _compile;
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
                _compile = value;
            }
        }

        private object? _compileExpressions;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#compile_expressions MdbClickhouseCluster#compile_expressions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "compileExpressions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CompileExpressions
        {
            get => _compileExpressions;
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
                _compileExpressions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#connect_timeout MdbClickhouseCluster#connect_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#count_distinct_implementation MdbClickhouseCluster#count_distinct_implementation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "countDistinctImplementation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CountDistinctImplementation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#distinct_overflow_mode MdbClickhouseCluster#distinct_overflow_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "distinctOverflowMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DistinctOverflowMode
        {
            get;
            set;
        }

        private object? _distributedAggregationMemoryEfficient;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#distributed_aggregation_memory_efficient MdbClickhouseCluster#distributed_aggregation_memory_efficient}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "distributedAggregationMemoryEfficient", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DistributedAggregationMemoryEfficient
        {
            get => _distributedAggregationMemoryEfficient;
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
                _distributedAggregationMemoryEfficient = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#distributed_ddl_task_timeout MdbClickhouseCluster#distributed_ddl_task_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "distributedDdlTaskTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DistributedDdlTaskTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#distributed_product_mode MdbClickhouseCluster#distributed_product_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "distributedProductMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DistributedProductMode
        {
            get;
            set;
        }

        private object? _emptyResultForAggregationByEmptySet;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#empty_result_for_aggregation_by_empty_set MdbClickhouseCluster#empty_result_for_aggregation_by_empty_set}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emptyResultForAggregationByEmptySet", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EmptyResultForAggregationByEmptySet
        {
            get => _emptyResultForAggregationByEmptySet;
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
                _emptyResultForAggregationByEmptySet = value;
            }
        }

        private object? _enableHttpCompression;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#enable_http_compression MdbClickhouseCluster#enable_http_compression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableHttpCompression", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableHttpCompression
        {
            get => _enableHttpCompression;
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
                _enableHttpCompression = value;
            }
        }

        private object? _fallbackToStaleReplicasForDistributedQueries;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#fallback_to_stale_replicas_for_distributed_queries MdbClickhouseCluster#fallback_to_stale_replicas_for_distributed_queries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fallbackToStaleReplicasForDistributedQueries", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? FallbackToStaleReplicasForDistributedQueries
        {
            get => _fallbackToStaleReplicasForDistributedQueries;
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
                _fallbackToStaleReplicasForDistributedQueries = value;
            }
        }

        private object? _forceIndexByDate;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#force_index_by_date MdbClickhouseCluster#force_index_by_date}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forceIndexByDate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ForceIndexByDate
        {
            get => _forceIndexByDate;
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
                _forceIndexByDate = value;
            }
        }

        private object? _forcePrimaryKey;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#force_primary_key MdbClickhouseCluster#force_primary_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forcePrimaryKey", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? ForcePrimaryKey
        {
            get => _forcePrimaryKey;
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
                _forcePrimaryKey = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#group_by_overflow_mode MdbClickhouseCluster#group_by_overflow_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupByOverflowMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupByOverflowMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#group_by_two_level_threshold MdbClickhouseCluster#group_by_two_level_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupByTwoLevelThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GroupByTwoLevelThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#group_by_two_level_threshold_bytes MdbClickhouseCluster#group_by_two_level_threshold_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupByTwoLevelThresholdBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GroupByTwoLevelThresholdBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#http_connection_timeout MdbClickhouseCluster#http_connection_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpConnectionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpConnectionTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#http_headers_progress_interval MdbClickhouseCluster#http_headers_progress_interval}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpHeadersProgressInterval", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpHeadersProgressInterval
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#http_receive_timeout MdbClickhouseCluster#http_receive_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpReceiveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpReceiveTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#http_send_timeout MdbClickhouseCluster#http_send_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpSendTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpSendTimeout
        {
            get;
            set;
        }

        private object? _inputFormatDefaultsForOmittedFields;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#input_format_defaults_for_omitted_fields MdbClickhouseCluster#input_format_defaults_for_omitted_fields}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputFormatDefaultsForOmittedFields", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InputFormatDefaultsForOmittedFields
        {
            get => _inputFormatDefaultsForOmittedFields;
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
                _inputFormatDefaultsForOmittedFields = value;
            }
        }

        private object? _inputFormatValuesInterpretExpressions;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#input_format_values_interpret_expressions MdbClickhouseCluster#input_format_values_interpret_expressions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "inputFormatValuesInterpretExpressions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? InputFormatValuesInterpretExpressions
        {
            get => _inputFormatValuesInterpretExpressions;
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
                _inputFormatValuesInterpretExpressions = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#insert_quorum MdbClickhouseCluster#insert_quorum}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "insertQuorum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InsertQuorum
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#insert_quorum_timeout MdbClickhouseCluster#insert_quorum_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "insertQuorumTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? InsertQuorumTimeout
        {
            get;
            set;
        }

        private object? _joinedSubqueryRequiresAlias;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#joined_subquery_requires_alias MdbClickhouseCluster#joined_subquery_requires_alias}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "joinedSubqueryRequiresAlias", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? JoinedSubqueryRequiresAlias
        {
            get => _joinedSubqueryRequiresAlias;
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
                _joinedSubqueryRequiresAlias = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#join_overflow_mode MdbClickhouseCluster#join_overflow_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "joinOverflowMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? JoinOverflowMode
        {
            get;
            set;
        }

        private object? _joinUseNulls;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#join_use_nulls MdbClickhouseCluster#join_use_nulls}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "joinUseNulls", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? JoinUseNulls
        {
            get => _joinUseNulls;
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
                _joinUseNulls = value;
            }
        }

        private object? _lowCardinalityAllowInNativeFormat;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#low_cardinality_allow_in_native_format MdbClickhouseCluster#low_cardinality_allow_in_native_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lowCardinalityAllowInNativeFormat", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? LowCardinalityAllowInNativeFormat
        {
            get => _lowCardinalityAllowInNativeFormat;
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
                _lowCardinalityAllowInNativeFormat = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_ast_depth MdbClickhouseCluster#max_ast_depth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAstDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAstDepth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_ast_elements MdbClickhouseCluster#max_ast_elements}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAstElements", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxAstElements
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_block_size MdbClickhouseCluster#max_block_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBlockSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBlockSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_bytes_before_external_group_by MdbClickhouseCluster#max_bytes_before_external_group_by}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBytesBeforeExternalGroupBy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBytesBeforeExternalGroupBy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_bytes_before_external_sort MdbClickhouseCluster#max_bytes_before_external_sort}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBytesBeforeExternalSort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBytesBeforeExternalSort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_bytes_in_distinct MdbClickhouseCluster#max_bytes_in_distinct}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBytesInDistinct", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBytesInDistinct
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_bytes_in_join MdbClickhouseCluster#max_bytes_in_join}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBytesInJoin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBytesInJoin
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_bytes_in_set MdbClickhouseCluster#max_bytes_in_set}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBytesInSet", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBytesInSet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_bytes_to_read MdbClickhouseCluster#max_bytes_to_read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBytesToRead", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBytesToRead
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_bytes_to_sort MdbClickhouseCluster#max_bytes_to_sort}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBytesToSort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBytesToSort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_bytes_to_transfer MdbClickhouseCluster#max_bytes_to_transfer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxBytesToTransfer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxBytesToTransfer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_columns_to_read MdbClickhouseCluster#max_columns_to_read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxColumnsToRead", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxColumnsToRead
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_execution_time MdbClickhouseCluster#max_execution_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxExecutionTime", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxExecutionTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_expanded_ast_elements MdbClickhouseCluster#max_expanded_ast_elements}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxExpandedAstElements", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxExpandedAstElements
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_insert_block_size MdbClickhouseCluster#max_insert_block_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxInsertBlockSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxInsertBlockSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_memory_usage MdbClickhouseCluster#max_memory_usage}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxMemoryUsage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxMemoryUsage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_memory_usage_for_user MdbClickhouseCluster#max_memory_usage_for_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxMemoryUsageForUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxMemoryUsageForUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_network_bandwidth MdbClickhouseCluster#max_network_bandwidth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxNetworkBandwidth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxNetworkBandwidth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_network_bandwidth_for_user MdbClickhouseCluster#max_network_bandwidth_for_user}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxNetworkBandwidthForUser", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxNetworkBandwidthForUser
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_query_size MdbClickhouseCluster#max_query_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxQuerySize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxQuerySize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_replica_delay_for_distributed_queries MdbClickhouseCluster#max_replica_delay_for_distributed_queries}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxReplicaDelayForDistributedQueries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxReplicaDelayForDistributedQueries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_result_bytes MdbClickhouseCluster#max_result_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxResultBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxResultBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_result_rows MdbClickhouseCluster#max_result_rows}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxResultRows", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxResultRows
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_rows_in_distinct MdbClickhouseCluster#max_rows_in_distinct}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRowsInDistinct", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRowsInDistinct
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_rows_in_join MdbClickhouseCluster#max_rows_in_join}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRowsInJoin", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRowsInJoin
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_rows_in_set MdbClickhouseCluster#max_rows_in_set}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRowsInSet", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRowsInSet
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_rows_to_group_by MdbClickhouseCluster#max_rows_to_group_by}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRowsToGroupBy", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRowsToGroupBy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_rows_to_read MdbClickhouseCluster#max_rows_to_read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRowsToRead", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRowsToRead
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_rows_to_sort MdbClickhouseCluster#max_rows_to_sort}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRowsToSort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRowsToSort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_rows_to_transfer MdbClickhouseCluster#max_rows_to_transfer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRowsToTransfer", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRowsToTransfer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_temporary_columns MdbClickhouseCluster#max_temporary_columns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTemporaryColumns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTemporaryColumns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_temporary_non_const_columns MdbClickhouseCluster#max_temporary_non_const_columns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTemporaryNonConstColumns", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTemporaryNonConstColumns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_threads MdbClickhouseCluster#max_threads}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxThreads", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxThreads
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#merge_tree_max_bytes_to_use_cache MdbClickhouseCluster#merge_tree_max_bytes_to_use_cache}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mergeTreeMaxBytesToUseCache", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MergeTreeMaxBytesToUseCache
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#merge_tree_max_rows_to_use_cache MdbClickhouseCluster#merge_tree_max_rows_to_use_cache}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mergeTreeMaxRowsToUseCache", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MergeTreeMaxRowsToUseCache
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#merge_tree_min_bytes_for_concurrent_read MdbClickhouseCluster#merge_tree_min_bytes_for_concurrent_read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mergeTreeMinBytesForConcurrentRead", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MergeTreeMinBytesForConcurrentRead
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#merge_tree_min_rows_for_concurrent_read MdbClickhouseCluster#merge_tree_min_rows_for_concurrent_read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mergeTreeMinRowsForConcurrentRead", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MergeTreeMinRowsForConcurrentRead
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_bytes_to_use_direct_io MdbClickhouseCluster#min_bytes_to_use_direct_io}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minBytesToUseDirectIo", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinBytesToUseDirectIo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_count_to_compile MdbClickhouseCluster#min_count_to_compile}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minCountToCompile", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinCountToCompile
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_count_to_compile_expression MdbClickhouseCluster#min_count_to_compile_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minCountToCompileExpression", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinCountToCompileExpression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_execution_speed MdbClickhouseCluster#min_execution_speed}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minExecutionSpeed", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinExecutionSpeed
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_execution_speed_bytes MdbClickhouseCluster#min_execution_speed_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minExecutionSpeedBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinExecutionSpeedBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_insert_block_size_bytes MdbClickhouseCluster#min_insert_block_size_bytes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minInsertBlockSizeBytes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinInsertBlockSizeBytes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#min_insert_block_size_rows MdbClickhouseCluster#min_insert_block_size_rows}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minInsertBlockSizeRows", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinInsertBlockSizeRows
        {
            get;
            set;
        }

        private object? _outputFormatJsonQuote64BitIntegers;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#output_format_json_quote_64bit_integers MdbClickhouseCluster#output_format_json_quote_64bit_integers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputFormatJsonQuote64BitIntegers", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? OutputFormatJsonQuote64BitIntegers
        {
            get => _outputFormatJsonQuote64BitIntegers;
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
                _outputFormatJsonQuote64BitIntegers = value;
            }
        }

        private object? _outputFormatJsonQuoteDenormals;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#output_format_json_quote_denormals MdbClickhouseCluster#output_format_json_quote_denormals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outputFormatJsonQuoteDenormals", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? OutputFormatJsonQuoteDenormals
        {
            get => _outputFormatJsonQuoteDenormals;
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
                _outputFormatJsonQuoteDenormals = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#priority MdbClickhouseCluster#priority}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Priority
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#quota_mode MdbClickhouseCluster#quota_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "quotaMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QuotaMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#readonly MdbClickhouseCluster#readonly}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readonly", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Readonly
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#read_overflow_mode MdbClickhouseCluster#read_overflow_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readOverflowMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReadOverflowMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#receive_timeout MdbClickhouseCluster#receive_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "receiveTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReceiveTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#replication_alter_partitions_sync MdbClickhouseCluster#replication_alter_partitions_sync}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationAlterPartitionsSync", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReplicationAlterPartitionsSync
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#result_overflow_mode MdbClickhouseCluster#result_overflow_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "resultOverflowMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResultOverflowMode
        {
            get;
            set;
        }

        private object? _selectSequentialConsistency;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#select_sequential_consistency MdbClickhouseCluster#select_sequential_consistency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selectSequentialConsistency", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SelectSequentialConsistency
        {
            get => _selectSequentialConsistency;
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
                _selectSequentialConsistency = value;
            }
        }

        private object? _sendProgressInHttpHeaders;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#send_progress_in_http_headers MdbClickhouseCluster#send_progress_in_http_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sendProgressInHttpHeaders", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SendProgressInHttpHeaders
        {
            get => _sendProgressInHttpHeaders;
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
                _sendProgressInHttpHeaders = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#send_timeout MdbClickhouseCluster#send_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sendTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SendTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#set_overflow_mode MdbClickhouseCluster#set_overflow_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "setOverflowMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SetOverflowMode
        {
            get;
            set;
        }

        private object? _skipUnavailableShards;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#skip_unavailable_shards MdbClickhouseCluster#skip_unavailable_shards}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skipUnavailableShards", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SkipUnavailableShards
        {
            get => _skipUnavailableShards;
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
                _skipUnavailableShards = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#sort_overflow_mode MdbClickhouseCluster#sort_overflow_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sortOverflowMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SortOverflowMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#timeout_overflow_mode MdbClickhouseCluster#timeout_overflow_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutOverflowMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeoutOverflowMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#transfer_overflow_mode MdbClickhouseCluster#transfer_overflow_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transferOverflowMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TransferOverflowMode
        {
            get;
            set;
        }

        private object? _transformNullIn;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#transform_null_in MdbClickhouseCluster#transform_null_in}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transformNullIn", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? TransformNullIn
        {
            get => _transformNullIn;
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
                _transformNullIn = value;
            }
        }

        private object? _useUncompressedCache;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#use_uncompressed_cache MdbClickhouseCluster#use_uncompressed_cache}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "useUncompressedCache", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? UseUncompressedCache
        {
            get => _useUncompressedCache;
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
                _useUncompressedCache = value;
            }
        }
    }
}
