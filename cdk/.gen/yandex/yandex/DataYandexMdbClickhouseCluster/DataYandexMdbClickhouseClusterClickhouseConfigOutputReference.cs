using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbClickhouseCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigOutputReference), fullyQualifiedName: "yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexMdbClickhouseClusterClickhouseConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexMdbClickhouseClusterClickhouseConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbClickhouseClusterClickhouseConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbClickhouseClusterClickhouseConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "backgroundPoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackgroundPoolSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backgroundSchedulePoolSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackgroundSchedulePoolSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "compression", typeJson: "{\"fqn\":\"yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigCompressionList\"}")]
        public virtual yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigCompressionList Compression
        {
            get => GetInstanceProperty<yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigCompressionList>()!;
        }

        [JsiiProperty(name: "geobaseUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GeobaseUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "graphiteRollup", typeJson: "{\"fqn\":\"yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigGraphiteRollupList\"}")]
        public virtual yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigGraphiteRollupList GraphiteRollup
        {
            get => GetInstanceProperty<yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigGraphiteRollupList>()!;
        }

        [JsiiProperty(name: "kafka", typeJson: "{\"fqn\":\"yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigKafkaList\"}")]
        public virtual yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigKafkaList Kafka
        {
            get => GetInstanceProperty<yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigKafkaList>()!;
        }

        [JsiiProperty(name: "kafkaTopic", typeJson: "{\"fqn\":\"yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigKafkaTopicList\"}")]
        public virtual yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigKafkaTopicList KafkaTopic
        {
            get => GetInstanceProperty<yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigKafkaTopicList>()!;
        }

        [JsiiProperty(name: "keepAliveTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double KeepAliveTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "markCacheSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MarkCacheSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxConcurrentQueries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrentQueries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxConnections", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConnections
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxPartitionSizeToDrop", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPartitionSizeToDrop
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxTableSizeToDrop", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTableSizeToDrop
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mergeTree", typeJson: "{\"fqn\":\"yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigMergeTreeList\"}")]
        public virtual yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigMergeTreeList MergeTree
        {
            get => GetInstanceProperty<yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigMergeTreeList>()!;
        }

        [JsiiProperty(name: "metricLogEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable MetricLogEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "metricLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MetricLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "metricLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MetricLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "partLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PartLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "partLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PartLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "queryLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueryLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "queryLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueryLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "queryThreadLogEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable QueryThreadLogEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "queryThreadLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueryThreadLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "queryThreadLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueryThreadLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rabbitmq", typeJson: "{\"fqn\":\"yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigRabbitmqList\"}")]
        public virtual yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigRabbitmqList Rabbitmq
        {
            get => GetInstanceProperty<yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfigRabbitmqList>()!;
        }

        [JsiiProperty(name: "textLogEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable TextLogEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "textLogLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TextLogLevel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "textLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TextLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "textLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TextLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "traceLogEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable TraceLogEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "traceLogRetentionSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TraceLogRetentionSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "traceLogRetentionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TraceLogRetentionTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "uncompressedCacheSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UncompressedCacheSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterClickhouseConfig\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbClickhouseCluster.IDataYandexMdbClickhouseClusterClickhouseConfig? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbClickhouseCluster.IDataYandexMdbClickhouseClusterClickhouseConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
