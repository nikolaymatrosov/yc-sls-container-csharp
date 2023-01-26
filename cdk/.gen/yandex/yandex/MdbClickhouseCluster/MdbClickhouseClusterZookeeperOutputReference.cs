using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbClickhouseCluster.MdbClickhouseClusterZookeeperOutputReference), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeperOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbClickhouseClusterZookeeperOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbClickhouseClusterZookeeperOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbClickhouseClusterZookeeperOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbClickhouseClusterZookeeperOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeperResources\"}}]")]
        public virtual void PutResources(yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeperResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeperResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetResources")]
        public virtual void ResetResources()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeperResourcesOutputReference\"}")]
        public virtual yandex.MdbClickhouseCluster.MdbClickhouseClusterZookeeperResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.MdbClickhouseClusterZookeeperResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeperResources\"}", isOptional: true)]
        public virtual yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeperResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeperResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterZookeeper\"}", isOptional: true)]
        public virtual yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeper? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterZookeeper?>();
            set => SetInstanceProperty(value);
        }
    }
}
