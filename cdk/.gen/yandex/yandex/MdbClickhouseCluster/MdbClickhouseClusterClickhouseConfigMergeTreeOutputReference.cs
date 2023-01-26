using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTreeOutputReference), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTreeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbClickhouseClusterClickhouseConfigMergeTreeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbClickhouseClusterClickhouseConfigMergeTreeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbClickhouseClusterClickhouseConfigMergeTreeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbClickhouseClusterClickhouseConfigMergeTreeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxBytesToMergeAtMinSpaceInPool")]
        public virtual void ResetMaxBytesToMergeAtMinSpaceInPool()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxReplicatedMergesInQueue")]
        public virtual void ResetMaxReplicatedMergesInQueue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNumberOfFreeEntriesInPoolToLowerMaxSizeOfMerge")]
        public virtual void ResetNumberOfFreeEntriesInPoolToLowerMaxSizeOfMerge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartsToDelayInsert")]
        public virtual void ResetPartsToDelayInsert()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPartsToThrowInsert")]
        public virtual void ResetPartsToThrowInsert()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicatedDeduplicationWindow")]
        public virtual void ResetReplicatedDeduplicationWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicatedDeduplicationWindowSeconds")]
        public virtual void ResetReplicatedDeduplicationWindowSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxBytesToMergeAtMinSpaceInPoolInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxBytesToMergeAtMinSpaceInPoolInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxReplicatedMergesInQueueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxReplicatedMergesInQueueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "numberOfFreeEntriesInPoolToLowerMaxSizeOfMergeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NumberOfFreeEntriesInPoolToLowerMaxSizeOfMergeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partsToDelayInsertInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PartsToDelayInsertInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partsToThrowInsertInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PartsToThrowInsertInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicatedDeduplicationWindowInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicatedDeduplicationWindowInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicatedDeduplicationWindowSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicatedDeduplicationWindowSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxBytesToMergeAtMinSpaceInPool", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxBytesToMergeAtMinSpaceInPool
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxReplicatedMergesInQueue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxReplicatedMergesInQueue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "numberOfFreeEntriesInPoolToLowerMaxSizeOfMerge", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NumberOfFreeEntriesInPoolToLowerMaxSizeOfMerge
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partsToDelayInsert", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PartsToDelayInsert
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partsToThrowInsert", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PartsToThrowInsert
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicatedDeduplicationWindow", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicatedDeduplicationWindow
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicatedDeduplicationWindowSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicatedDeduplicationWindowSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigMergeTree\"}", isOptional: true)]
        public virtual yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigMergeTree?>();
            set => SetInstanceProperty(value);
        }
    }
}
