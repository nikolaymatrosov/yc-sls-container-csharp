using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaOutputReference), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataYandexMdbKafkaClusterConfigKafkaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataYandexMdbKafkaClusterConfigKafkaOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataYandexMdbKafkaClusterConfigKafkaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbKafkaClusterConfigKafkaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKafkaConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaKafkaConfig\"}}]")]
        public virtual void PutKafkaConfig(yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaKafkaConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaKafkaConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResources\"}}]")]
        public virtual void PutResources(yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKafkaConfig")]
        public virtual void ResetKafkaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "kafkaConfig", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaKafkaConfigOutputReference\"}")]
        public virtual yandex.DataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaKafkaConfigOutputReference KafkaConfig
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaKafkaConfigOutputReference>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResourcesOutputReference\"}")]
        public virtual yandex.DataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kafkaConfigInput", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaKafkaConfig\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaKafkaConfig? KafkaConfigInput
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaKafkaConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafkaResources\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafkaResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigKafka\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafka? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigKafka?>();
            set => SetInstanceProperty(value);
        }
    }
}
