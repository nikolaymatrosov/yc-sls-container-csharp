using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaTopic
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbKafkaTopic.DataYandexMdbKafkaTopicTopicConfigOutputReference), fullyQualifiedName: "yandex.dataYandexMdbKafkaTopic.DataYandexMdbKafkaTopicTopicConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexMdbKafkaTopicTopicConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexMdbKafkaTopicTopicConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexMdbKafkaTopicTopicConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbKafkaTopicTopicConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CleanupPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compressionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompressionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteRetentionMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeleteRetentionMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileDeleteDelayMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileDeleteDelayMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flushMessages", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlushMessages
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flushMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlushMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxMessageBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxMessageBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minCompactionLagMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinCompactionLagMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "minInsyncReplicas", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MinInsyncReplicas
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "preallocate", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Preallocate
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "retentionBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetentionBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "retentionMs", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetentionMs
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "segmentBytes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SegmentBytes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaTopic.DataYandexMdbKafkaTopicTopicConfig\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbKafkaTopic.IDataYandexMdbKafkaTopicTopicConfig? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaTopic.IDataYandexMdbKafkaTopicTopicConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
