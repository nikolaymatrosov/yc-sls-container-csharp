using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbKafkaCluster.MdbKafkaClusterConfigKafkaOutputReference), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbKafkaClusterConfigKafkaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbKafkaClusterConfigKafkaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbKafkaClusterConfigKafkaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbKafkaClusterConfigKafkaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKafkaConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaKafkaConfig\"}}]")]
        public virtual void PutKafkaConfig(yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaKafkaConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaKafkaConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaResources\"}}]")]
        public virtual void PutResources(yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKafkaConfig")]
        public virtual void ResetKafkaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "kafkaConfig", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaKafkaConfigOutputReference\"}")]
        public virtual yandex.MdbKafkaCluster.MdbKafkaClusterConfigKafkaKafkaConfigOutputReference KafkaConfig
        {
            get => GetInstanceProperty<yandex.MdbKafkaCluster.MdbKafkaClusterConfigKafkaKafkaConfigOutputReference>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaResourcesOutputReference\"}")]
        public virtual yandex.MdbKafkaCluster.MdbKafkaClusterConfigKafkaResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.MdbKafkaCluster.MdbKafkaClusterConfigKafkaResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaConfigInput", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaKafkaConfig\"}", isOptional: true)]
        public virtual yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaKafkaConfig? KafkaConfigInput
        {
            get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaKafkaConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafkaResources\"}", isOptional: true)]
        public virtual yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafkaResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigKafka\"}", isOptional: true)]
        public virtual yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafka? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigKafka?>();
            set => SetInstanceProperty(value);
        }
    }
}
