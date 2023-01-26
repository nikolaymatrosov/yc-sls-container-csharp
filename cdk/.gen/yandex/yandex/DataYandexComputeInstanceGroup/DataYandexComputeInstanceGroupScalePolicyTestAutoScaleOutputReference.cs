using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstanceGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupScalePolicyTestAutoScaleOutputReference), fullyQualifiedName: "yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupScalePolicyTestAutoScaleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexComputeInstanceGroupScalePolicyTestAutoScaleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexComputeInstanceGroupScalePolicyTestAutoScaleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexComputeInstanceGroupScalePolicyTestAutoScaleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstanceGroupScalePolicyTestAutoScaleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cpuUtilizationTarget", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuUtilizationTarget
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "customRule", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleList CustomRule
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleList>()!;
        }

        [JsiiProperty(name: "initialSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "measurementDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MeasurementDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minZoneSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinZoneSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "stabilizationDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StabilizationDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "warmupDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WarmupDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupScalePolicyTestAutoScale\"}", isOptional: true)]
        public virtual yandex.DataYandexComputeInstanceGroup.IDataYandexComputeInstanceGroupScalePolicyTestAutoScale? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.IDataYandexComputeInstanceGroupScalePolicyTestAutoScale?>();
            set => SetInstanceProperty(value);
        }
    }
}
