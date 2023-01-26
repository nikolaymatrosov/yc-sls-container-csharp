using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaTopic
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic yandex_mdb_kafka_topic}.</summary>
    [JsiiClass(nativeType: typeof(yandex.MdbKafkaTopic.MdbKafkaTopic), fullyQualifiedName: "yandex.mdbKafkaTopic.MdbKafkaTopic", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.mdbKafkaTopic.MdbKafkaTopicConfig\"}}]")]
    public class MdbKafkaTopic : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_topic yandex_mdb_kafka_topic} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MdbKafkaTopic(Constructs.Construct scope, string id, yandex.MdbKafkaTopic.IMdbKafkaTopicConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.MdbKafkaTopic.IMdbKafkaTopicConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbKafkaTopic(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbKafkaTopic(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbKafkaTopic.MdbKafkaTopicTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.MdbKafkaTopic.IMdbKafkaTopicTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbKafkaTopic.IMdbKafkaTopicTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTopicConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbKafkaTopic.MdbKafkaTopicTopicConfig\"}}]")]
        public virtual void PutTopicConfig(yandex.MdbKafkaTopic.IMdbKafkaTopicTopicConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbKafkaTopic.IMdbKafkaTopicTopicConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTopicConfig")]
        public virtual void ResetTopicConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(yandex.MdbKafkaTopic.MdbKafkaTopic))!;

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.mdbKafkaTopic.MdbKafkaTopicTimeoutsOutputReference\"}")]
        public virtual yandex.MdbKafkaTopic.MdbKafkaTopicTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.MdbKafkaTopic.MdbKafkaTopicTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "topicConfig", typeJson: "{\"fqn\":\"yandex.mdbKafkaTopic.MdbKafkaTopicTopicConfigOutputReference\"}")]
        public virtual yandex.MdbKafkaTopic.MdbKafkaTopicTopicConfigOutputReference TopicConfig
        {
            get => GetInstanceProperty<yandex.MdbKafkaTopic.MdbKafkaTopicTopicConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "partitionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PartitionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationFactorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicationFactorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.mdbKafkaTopic.MdbKafkaTopicTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicConfigInput", typeJson: "{\"fqn\":\"yandex.mdbKafkaTopic.MdbKafkaTopicTopicConfig\"}", isOptional: true)]
        public virtual yandex.MdbKafkaTopic.IMdbKafkaTopicTopicConfig? TopicConfigInput
        {
            get => GetInstanceProperty<yandex.MdbKafkaTopic.IMdbKafkaTopicTopicConfig?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "partitions", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Partitions
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicationFactor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
