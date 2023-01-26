using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbElasticsearchCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeOutputReference), fullyQualifiedName: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbElasticsearchClusterConfigDataNodeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbElasticsearchClusterConfigDataNodeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbElasticsearchClusterConfigDataNodeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbElasticsearchClusterConfigDataNodeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeResources\"}}]")]
        public virtual void PutResources(yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNodeResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNodeResources)}, new object[]{@value});
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeResourcesOutputReference\"}")]
        public virtual yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeResources\"}", isOptional: true)]
        public virtual yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNodeResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNodeResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNode\"}", isOptional: true)]
        public virtual yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode?>();
            set => SetInstanceProperty(value);
        }
    }
}
