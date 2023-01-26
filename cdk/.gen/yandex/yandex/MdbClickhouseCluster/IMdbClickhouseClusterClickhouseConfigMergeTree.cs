using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterClickhouseConfigMergeTree), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTree")]
    public interface IMdbClickhouseClusterClickhouseConfigMergeTree
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_bytes_to_merge_at_min_space_in_pool MdbClickhouseCluster#max_bytes_to_merge_at_min_space_in_pool}.</summary>
        [JsiiProperty(name: "maxBytesToMergeAtMinSpaceInPool", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxBytesToMergeAtMinSpaceInPool
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_replicated_merges_in_queue MdbClickhouseCluster#max_replicated_merges_in_queue}.</summary>
        [JsiiProperty(name: "maxReplicatedMergesInQueue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxReplicatedMergesInQueue
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#number_of_free_entries_in_pool_to_lower_max_size_of_merge MdbClickhouseCluster#number_of_free_entries_in_pool_to_lower_max_size_of_merge}.</summary>
        [JsiiProperty(name: "numberOfFreeEntriesInPoolToLowerMaxSizeOfMerge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfFreeEntriesInPoolToLowerMaxSizeOfMerge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#parts_to_delay_insert MdbClickhouseCluster#parts_to_delay_insert}.</summary>
        [JsiiProperty(name: "partsToDelayInsert", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PartsToDelayInsert
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#parts_to_throw_insert MdbClickhouseCluster#parts_to_throw_insert}.</summary>
        [JsiiProperty(name: "partsToThrowInsert", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PartsToThrowInsert
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#replicated_deduplication_window MdbClickhouseCluster#replicated_deduplication_window}.</summary>
        [JsiiProperty(name: "replicatedDeduplicationWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicatedDeduplicationWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#replicated_deduplication_window_seconds MdbClickhouseCluster#replicated_deduplication_window_seconds}.</summary>
        [JsiiProperty(name: "replicatedDeduplicationWindowSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicatedDeduplicationWindowSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterClickhouseConfigMergeTree), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTree")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_bytes_to_merge_at_min_space_in_pool MdbClickhouseCluster#max_bytes_to_merge_at_min_space_in_pool}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxBytesToMergeAtMinSpaceInPool", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxBytesToMergeAtMinSpaceInPool
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#max_replicated_merges_in_queue MdbClickhouseCluster#max_replicated_merges_in_queue}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxReplicatedMergesInQueue", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxReplicatedMergesInQueue
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#number_of_free_entries_in_pool_to_lower_max_size_of_merge MdbClickhouseCluster#number_of_free_entries_in_pool_to_lower_max_size_of_merge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numberOfFreeEntriesInPoolToLowerMaxSizeOfMerge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfFreeEntriesInPoolToLowerMaxSizeOfMerge
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#parts_to_delay_insert MdbClickhouseCluster#parts_to_delay_insert}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partsToDelayInsert", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PartsToDelayInsert
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#parts_to_throw_insert MdbClickhouseCluster#parts_to_throw_insert}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "partsToThrowInsert", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PartsToThrowInsert
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#replicated_deduplication_window MdbClickhouseCluster#replicated_deduplication_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicatedDeduplicationWindow", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicatedDeduplicationWindow
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#replicated_deduplication_window_seconds MdbClickhouseCluster#replicated_deduplication_window_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicatedDeduplicationWindowSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicatedDeduplicationWindowSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
