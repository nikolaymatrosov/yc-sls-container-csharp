using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbKafkaCluster.MdbKafkaClusterConfigZookeeperOutputReference), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeperOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbKafkaClusterConfigZookeeperOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbKafkaClusterConfigZookeeperOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbKafkaClusterConfigZookeeperOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbKafkaClusterConfigZookeeperOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeperResources\"}}]")]
        public virtual void PutResources(yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeperResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeperResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetResources")]
        public virtual void ResetResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeperResourcesOutputReference\"}")]
        public virtual yandex.MdbKafkaCluster.MdbKafkaClusterConfigZookeeperResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.MdbKafkaCluster.MdbKafkaClusterConfigZookeeperResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeperResources\"}", isOptional: true)]
        public virtual yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeperResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeperResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbKafkaCluster.MdbKafkaClusterConfigZookeeper\"}", isOptional: true)]
        public virtual yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeper? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbKafkaCluster.IMdbKafkaClusterConfigZookeeper?>();
            set => SetInstanceProperty(value);
        }
    }
}
