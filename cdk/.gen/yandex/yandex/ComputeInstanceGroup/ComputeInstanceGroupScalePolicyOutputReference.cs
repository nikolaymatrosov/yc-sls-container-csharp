using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiClass(nativeType: typeof(yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyOutputReference), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ComputeInstanceGroupScalePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ComputeInstanceGroupScalePolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ComputeInstanceGroupScalePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeInstanceGroupScalePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScale\"}}]")]
        public virtual void PutAutoScale(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScale @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScale)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFixedScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyFixedScale\"}}]")]
        public virtual void PutFixedScale(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyFixedScale @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyFixedScale)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTestAutoScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScale\"}}]")]
        public virtual void PutTestAutoScale(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScale @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScale)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoScale")]
        public virtual void ResetAutoScale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFixedScale")]
        public virtual void ResetFixedScale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTestAutoScale")]
        public virtual void ResetTestAutoScale()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScaleOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScaleOutputReference AutoScale
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScaleOutputReference>()!;
        }

        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyFixedScaleOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyFixedScaleOutputReference FixedScale
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyFixedScaleOutputReference>()!;
        }

        [JsiiProperty(name: "testAutoScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScaleOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScaleOutputReference TestAutoScale
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScaleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScaleInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScale\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScale? AutoScaleInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScale?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedScaleInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyFixedScale\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyFixedScale? FixedScaleInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyFixedScale?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "testAutoScaleInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScale\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScale? TestAutoScaleInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScale?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicy\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicy? InternalValue
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
