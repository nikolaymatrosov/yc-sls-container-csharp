using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstanceGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupApplicationLoadBalancerOutputReference), fullyQualifiedName: "yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupApplicationLoadBalancerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexComputeInstanceGroupApplicationLoadBalancerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexComputeInstanceGroupApplicationLoadBalancerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexComputeInstanceGroupApplicationLoadBalancerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstanceGroupApplicationLoadBalancerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "maxOpeningTrafficDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxOpeningTrafficDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "statusMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StatusMessage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetGroupDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetGroupDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetGroupLabels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap TargetGroupLabels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "targetGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetGroupName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupApplicationLoadBalancer\"}", isOptional: true)]
        public virtual yandex.DataYandexComputeInstanceGroup.IDataYandexComputeInstanceGroupApplicationLoadBalancer? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.IDataYandexComputeInstanceGroupApplicationLoadBalancer?>();
            set => SetInstanceProperty(value);
        }
    }
}
