using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeperOutputReference), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeperOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataYandexMdbKafkaClusterConfigZookeeperOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataYandexMdbKafkaClusterConfigZookeeperOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataYandexMdbKafkaClusterConfigZookeeperOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbKafkaClusterConfigZookeeperOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeperResources\"}}]")]
        public virtual void PutResources(yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeperResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeperResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetResources")]
        public virtual void ResetResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeperResourcesOutputReference\"}")]
        public virtual yandex.DataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeperResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeperResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeperResources\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeperResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeperResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigZookeeper\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeper? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigZookeeper?>();
            set => SetInstanceProperty(value);
        }
    }
}
