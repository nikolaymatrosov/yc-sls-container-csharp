using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbElasticsearchCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeOutputReference), fullyQualifiedName: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbElasticsearchClusterConfigMasterNodeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbElasticsearchClusterConfigMasterNodeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbElasticsearchClusterConfigMasterNodeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbElasticsearchClusterConfigMasterNodeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeResources\"}}]")]
        public virtual void PutResources(yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNodeResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNodeResources)}, new object[]{@value});
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeResourcesOutputReference\"}")]
        public virtual yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeResources\"}", isOptional: true)]
        public virtual yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNodeResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNodeResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNode\"}", isOptional: true)]
        public virtual yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode?>();
            set => SetInstanceProperty(value);
        }
    }
}
