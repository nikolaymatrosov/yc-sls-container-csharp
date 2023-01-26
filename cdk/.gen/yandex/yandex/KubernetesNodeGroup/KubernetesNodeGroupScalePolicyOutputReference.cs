using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiClass(nativeType: typeof(yandex.KubernetesNodeGroup.KubernetesNodeGroupScalePolicyOutputReference), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesNodeGroupScalePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesNodeGroupScalePolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesNodeGroupScalePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesNodeGroupScalePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyAutoScale\"}}]")]
        public virtual void PutAutoScale(yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyAutoScale @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyAutoScale)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFixedScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyFixedScale\"}}]")]
        public virtual void PutFixedScale(yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyFixedScale @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyFixedScale)}, new object[]{@value});
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

        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyAutoScaleOutputReference\"}")]
        public virtual yandex.KubernetesNodeGroup.KubernetesNodeGroupScalePolicyAutoScaleOutputReference AutoScale
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.KubernetesNodeGroupScalePolicyAutoScaleOutputReference>()!;
        }

        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyFixedScaleOutputReference\"}")]
        public virtual yandex.KubernetesNodeGroup.KubernetesNodeGroupScalePolicyFixedScaleOutputReference FixedScale
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.KubernetesNodeGroupScalePolicyFixedScaleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoScaleInput", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyAutoScale\"}", isOptional: true)]
        public virtual yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyAutoScale? AutoScaleInput
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyAutoScale?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedScaleInput", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyFixedScale\"}", isOptional: true)]
        public virtual yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyFixedScale? FixedScaleInput
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyFixedScale?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicy\"}", isOptional: true)]
        public virtual yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicy? InternalValue
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
