using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigOutputReference), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbClickhouseClusterClickhouseConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbClickhouseClusterClickhouseConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbClickhouseClusterClickhouseConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbClickhouseClusterClickhouseConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCompression", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompression\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCompression(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigCompression[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigCompression).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigCompression).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGraphiteRollup", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollup\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGraphiteRollup(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollup[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollup).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigGraphiteRollup).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafka", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafka\"}}]")]
        public virtual void PutKafka(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafka @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafka)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKafkaTopic", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaTopic\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutKafkaTopic(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafkaTopic[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafkaTopic).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafkaTopic).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMergeTree", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTree\"}}]")]
        public virtual void PutMergeTree(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRabbitmq", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigRabbitmq\"}}]")]
        public virtual void PutRabbitmq(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigRabbitmq @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigRabbitmq)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetBackgroundPoolSize")]
        public virtual void ResetBackgroundPoolSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackgroundSchedulePoolSize")]
        public virtual void ResetBackgroundSchedulePoolSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompression")]
        public virtual void ResetCompression()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeobaseUri")]
        public virtual void ResetGeobaseUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGraphiteRollup")]
        public virtual void ResetGraphiteRollup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKafka")]
        public virtual void ResetKafka()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKafkaTopic")]
        public virtual void ResetKafkaTopic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeepAliveTimeout")]
        public virtual void ResetKeepAliveTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogLevel")]
        public virtual void ResetLogLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMarkCacheSize")]
        public virtual void ResetMarkCacheSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxConcurrentQueries")]
        public virtual void ResetMaxConcurrentQueries()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxConnections")]
        public virtual void ResetMaxConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxPartitionSizeToDrop")]
        public virtual void ResetMaxPartitionSizeToDrop()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxTableSizeToDrop")]
        public virtual void ResetMaxTableSizeToDrop()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMergeTree")]
        public virtual void ResetMergeTree()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricLogEnabled")]
        public virtual void ResetMetricLogEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricLogRetentionSize")]
        public virtual void ResetMetricLogRetentionSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetricLogRetentionTime")]
        public virtual void ResetMetricLogRetentionTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartLogRetentionSize")]
        public virtual void ResetPartLogRetentionSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartLogRetentionTime")]
        public virtual void ResetPartLogRetentionTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryLogRetentionSize")]
        public virtual void ResetQueryLogRetentionSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryLogRetentionTime")]
        public virtual void ResetQueryLogRetentionTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryThreadLogEnabled")]
        public virtual void ResetQueryThreadLogEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryThreadLogRetentionSize")]
        public virtual void ResetQueryThreadLogRetentionSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQueryThreadLogRetentionTime")]
        public virtual void ResetQueryThreadLogRetentionTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRabbitmq")]
        public virtual void ResetRabbitmq()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTextLogEnabled")]
        public virtual void ResetTextLogEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTextLogLevel")]
        public virtual void ResetTextLogLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTextLogRetentionSize")]
        public virtual void ResetTextLogRetentionSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTextLogRetentionTime")]
        public virtual void ResetTextLogRetentionTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimezone")]
        public virtual void ResetTimezone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTraceLogEnabled")]
        public virtual void ResetTraceLogEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTraceLogRetentionSize")]
        public virtual void ResetTraceLogRetentionSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTraceLogRetentionTime")]
        public virtual void ResetTraceLogRetentionTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUncompressedCacheSize")]
        public virtual void ResetUncompressedCacheSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "compression", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompressionList\"}")]
        public virtual yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompressionList Compression
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompressionList>()!;
        }

        [JsiiProperty(name: "graphiteRollup", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupList\"}")]
        public virtual yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupList GraphiteRollup
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollupList>()!;
        }

        [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaOutputReference\"}")]
        public virtual yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaOutputReference Kafka
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaOutputReference>()!;
        }

        [JsiiProperty(name: "kafkaTopic", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaTopicList\"}")]
        public virtual yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaTopicList KafkaTopic
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaTopicList>()!;
        }

        [JsiiProperty(name: "mergeTree", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTreeOutputReference\"}")]
        public virtual yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTreeOutputReference MergeTree
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTreeOutputReference>()!;
        }

        [JsiiProperty(name: "rabbitmq", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigRabbitmqOutputReference\"}")]
        public virtual yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigRabbitmqOutputReference Rabbitmq
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigRabbitmqOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "backgroundPoolSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackgroundPoolSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backgroundSchedulePoolSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackgroundSchedulePoolSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigCompression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CompressionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geobaseUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? GeobaseUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "graphiteRollupInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigGraphiteRollup\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GraphiteRollupInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaInput", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafka\"}", isOptional: true)]
        public virtual yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafka? KafkaInput
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafka?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaTopicInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafkaTopic\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? KafkaTopicInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keepAliveTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? KeepAliveTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "markCacheSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MarkCacheSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentQueriesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConcurrentQueriesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConnectionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConnectionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxPartitionSizeToDropInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxPartitionSizeToDropInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxTableSizeToDropInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxTableSizeToDropInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mergeTreeInput", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTree\"}", isOptional: true)]
        public virtual yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree? MergeTreeInput
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricLogEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MetricLogEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricLogRetentionSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MetricLogRetentionSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metricLogRetentionTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MetricLogRetentionTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partLogRetentionSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PartLogRetentionSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partLogRetentionTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PartLogRetentionTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryLogRetentionSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QueryLogRetentionSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryLogRetentionTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QueryLogRetentionTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryThreadLogEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? QueryThreadLogEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryThreadLogRetentionSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QueryThreadLogRetentionSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryThreadLogRetentionTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QueryThreadLogRetentionTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rabbitmqInput", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigRabbitmq\"}", isOptional: true)]
        public virtual yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigRabbitmq? RabbitmqInput
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigRabbitmq?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textLogEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TextLogEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textLogLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TextLogLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textLogRetentionSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TextLogRetentionSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textLogRetentionTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TextLogRetentionTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "traceLogEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TraceLogEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "traceLogRetentionSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TraceLogRetentionSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "traceLogRetentionTimeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TraceLogRetentionTimeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uncompressedCacheSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UncompressedCacheSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "backgroundPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackgroundPoolSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backgroundSchedulePoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackgroundSchedulePoolSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "geobaseUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeobaseUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keepAliveTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeepAliveTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "markCacheSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MarkCacheSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxConcurrentQueries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrentQueries
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConnections
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxPartitionSizeToDrop", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPartitionSizeToDrop
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxTableSizeToDrop", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTableSizeToDrop
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object MetricLogEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "metricLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MetricLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metricLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MetricLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PartLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PartLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueryLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueryLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryThreadLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object QueryThreadLogEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "queryThreadLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueryThreadLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "queryThreadLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueryThreadLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "textLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TextLogEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "textLogLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TextLogLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "textLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TextLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "textLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TextLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "traceLogEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TraceLogEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "traceLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TraceLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "traceLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TraceLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uncompressedCacheSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UncompressedCacheSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfig\"}", isOptional: true)]
        public virtual yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
