using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstanceGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateOutputReference), fullyQualifiedName: "yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexComputeInstanceGroupInstanceTemplateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexComputeInstanceGroupInstanceTemplateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexComputeInstanceGroupInstanceTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstanceGroupInstanceTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bootDisk", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateBootDiskList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateBootDiskList BootDisk
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateBootDiskList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "networkSettings", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkSettingsList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkSettingsList NetworkSettings
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkSettingsList>()!;
        }

        [JsiiProperty(name: "placementPolicy", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplatePlacementPolicyList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplatePlacementPolicyList PlacementPolicy
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplatePlacementPolicyList>()!;
        }

        [JsiiProperty(name: "platformId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateResourcesList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateResourcesList Resources
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateResourcesList>()!;
        }

        [JsiiProperty(name: "schedulingPolicy", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateSchedulingPolicyList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateSchedulingPolicyList SchedulingPolicy
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateSchedulingPolicyList>()!;
        }

        [JsiiProperty(name: "secondaryDisk", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateSecondaryDiskList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateSecondaryDiskList SecondaryDisk
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateSecondaryDiskList>()!;
        }

        [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplate\"}", isOptional: true)]
        public virtual yandex.DataYandexComputeInstanceGroup.IDataYandexComputeInstanceGroupInstanceTemplate? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.IDataYandexComputeInstanceGroupInstanceTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}
