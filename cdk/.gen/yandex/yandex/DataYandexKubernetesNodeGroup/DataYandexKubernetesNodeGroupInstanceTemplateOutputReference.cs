using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexKubernetesNodeGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateOutputReference), fullyQualifiedName: "yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexKubernetesNodeGroupInstanceTemplateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexKubernetesNodeGroupInstanceTemplateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexKubernetesNodeGroupInstanceTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexKubernetesNodeGroupInstanceTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bootDisk", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateBootDiskList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateBootDiskList BootDisk
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateBootDiskList>()!;
        }

        [JsiiProperty(name: "containerRuntime", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateContainerRuntimeList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateContainerRuntimeList ContainerRuntime
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateContainerRuntimeList>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Metadata
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Nat
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "networkAccelerationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAccelerationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateNetworkInterfaceList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "placementPolicy", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplatePlacementPolicyList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplatePlacementPolicyList PlacementPolicy
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplatePlacementPolicyList>()!;
        }

        [JsiiProperty(name: "platformId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateResourcesList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateResourcesList Resources
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateResourcesList>()!;
        }

        [JsiiProperty(name: "schedulingPolicy", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateSchedulingPolicyList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateSchedulingPolicyList SchedulingPolicy
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateSchedulingPolicyList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplate\"}", isOptional: true)]
        public virtual yandex.DataYandexKubernetesNodeGroup.IDataYandexKubernetesNodeGroupInstanceTemplate? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.IDataYandexKubernetesNodeGroupInstanceTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}
