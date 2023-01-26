using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbClickhouseCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterUserSettingsOutputReference), fullyQualifiedName: "yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterUserSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexMdbClickhouseClusterUserSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexMdbClickhouseClusterUserSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexMdbClickhouseClusterUserSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbClickhouseClusterUserSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "addHttpCorsHeader", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AddHttpCorsHeader
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "allowDdl", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AllowDdl
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "compile", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Compile
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "compileExpressions", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable CompileExpressions
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "connectTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "countDistinctImplementation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CountDistinctImplementation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "distinctOverflowMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistinctOverflowMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "distributedAggregationMemoryEfficient", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DistributedAggregationMemoryEfficient
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "distributedDdlTaskTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DistributedDdlTaskTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "distributedProductMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DistributedProductMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emptyResultForAggregationByEmptySet", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EmptyResultForAggregationByEmptySet
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "enableHttpCompression", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable EnableHttpCompression
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "fallbackToStaleReplicasForDistributedQueries", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable FallbackToStaleReplicasForDistributedQueries
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "forceIndexByDate", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ForceIndexByDate
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "forcePrimaryKey", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable ForcePrimaryKey
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "groupByOverflowMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupByOverflowMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupByTwoLevelThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GroupByTwoLevelThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "groupByTwoLevelThresholdBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GroupByTwoLevelThresholdBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "httpConnectionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpConnectionTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "httpHeadersProgressInterval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpHeadersProgressInterval
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "httpReceiveTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpReceiveTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "httpSendTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HttpSendTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "inputFormatDefaultsForOmittedFields", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable InputFormatDefaultsForOmittedFields
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "inputFormatValuesInterpretExpressions", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable InputFormatValuesInterpretExpressions
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "insertQuorum", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InsertQuorum
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "insertQuorumTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InsertQuorumTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "joinedSubqueryRequiresAlias", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable JoinedSubqueryRequiresAlias
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "joinOverflowMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string JoinOverflowMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "joinUseNulls", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable JoinUseNulls
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "lowCardinalityAllowInNativeFormat", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable LowCardinalityAllowInNativeFormat
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "maxAstDepth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAstDepth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxAstElements", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAstElements
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxBlockSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBlockSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxBytesBeforeExternalGroupBy", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBytesBeforeExternalGroupBy
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxBytesBeforeExternalSort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBytesBeforeExternalSort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxBytesInDistinct", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBytesInDistinct
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxBytesInJoin", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBytesInJoin
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxBytesInSet", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBytesInSet
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxBytesToRead", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBytesToRead
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxBytesToSort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBytesToSort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxBytesToTransfer", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBytesToTransfer
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxColumnsToRead", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxColumnsToRead
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxExecutionTime", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxExecutionTime
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxExpandedAstElements", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxExpandedAstElements
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxInsertBlockSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxInsertBlockSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxMemoryUsage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxMemoryUsage
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxMemoryUsageForUser", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxMemoryUsageForUser
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxNetworkBandwidth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxNetworkBandwidth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxNetworkBandwidthForUser", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxNetworkBandwidthForUser
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxQuerySize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxQuerySize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxReplicaDelayForDistributedQueries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxReplicaDelayForDistributedQueries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxResultBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxResultBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxResultRows", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxResultRows
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxRowsInDistinct", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRowsInDistinct
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxRowsInJoin", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRowsInJoin
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxRowsInSet", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRowsInSet
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxRowsToGroupBy", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRowsToGroupBy
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxRowsToRead", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRowsToRead
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxRowsToSort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRowsToSort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxRowsToTransfer", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxRowsToTransfer
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxTemporaryColumns", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTemporaryColumns
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxTemporaryNonConstColumns", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxTemporaryNonConstColumns
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxThreads", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxThreads
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mergeTreeMaxBytesToUseCache", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MergeTreeMaxBytesToUseCache
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mergeTreeMaxRowsToUseCache", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MergeTreeMaxRowsToUseCache
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mergeTreeMinBytesForConcurrentRead", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MergeTreeMinBytesForConcurrentRead
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "mergeTreeMinRowsForConcurrentRead", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MergeTreeMinRowsForConcurrentRead
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minBytesToUseDirectIo", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinBytesToUseDirectIo
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minCountToCompile", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinCountToCompile
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minCountToCompileExpression", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinCountToCompileExpression
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minExecutionSpeed", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinExecutionSpeed
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minExecutionSpeedBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinExecutionSpeedBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minInsertBlockSizeBytes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinInsertBlockSizeBytes
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minInsertBlockSizeRows", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinInsertBlockSizeRows
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "outputFormatJsonQuote64BitIntegers", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable OutputFormatJsonQuote64BitIntegers
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "outputFormatJsonQuoteDenormals", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable OutputFormatJsonQuoteDenormals
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "quotaMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuotaMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "readonly", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Readonly
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "readOverflowMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReadOverflowMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "receiveTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReceiveTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "replicationAlterPartitionsSync", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicationAlterPartitionsSync
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "resultOverflowMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResultOverflowMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "selectSequentialConsistency", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable SelectSequentialConsistency
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "sendProgressInHttpHeaders", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable SendProgressInHttpHeaders
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "sendTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SendTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "setOverflowMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SetOverflowMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "skipUnavailableShards", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable SkipUnavailableShards
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "sortOverflowMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SortOverflowMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeoutOverflowMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeoutOverflowMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transferOverflowMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TransferOverflowMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "transformNullIn", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable TransformNullIn
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "useUncompressedCache", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable UseUncompressedCache
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterUserSettings\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbClickhouseCluster.IDataYandexMdbClickhouseClusterUserSettings? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbClickhouseCluster.IDataYandexMdbClickhouseClusterUserSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
