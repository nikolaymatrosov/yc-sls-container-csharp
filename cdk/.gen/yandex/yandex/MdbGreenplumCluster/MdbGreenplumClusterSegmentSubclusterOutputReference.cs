using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbGreenplumCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterOutputReference), fullyQualifiedName: "yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbGreenplumClusterSegmentSubclusterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbGreenplumClusterSegmentSubclusterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbGreenplumClusterSegmentSubclusterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbGreenplumClusterSegmentSubclusterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterResources\"}}]")]
        public virtual void PutResources(yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubclusterResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubclusterResources)}, new object[]{@value});
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterResourcesOutputReference\"}")]
        public virtual yandex.MdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterResources\"}", isOptional: true)]
        public virtual yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubclusterResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubclusterResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubcluster\"}", isOptional: true)]
        public virtual yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubcluster? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubcluster?>();
            set => SetInstanceProperty(value);
        }
    }
}
