using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiClass(nativeType: typeof(yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateResourcesOutputReference), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateResourcesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ComputeInstanceGroupInstanceTemplateResourcesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ComputeInstanceGroupInstanceTemplateResourcesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ComputeInstanceGroupInstanceTemplateResourcesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeInstanceGroupInstanceTemplateResourcesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCoreFraction")]
        public virtual void ResetCoreFraction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGpus")]
        public virtual void ResetGpus()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "coreFractionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CoreFractionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "coresInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CoresInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "gpusInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? GpusInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "memoryInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MemoryInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "coreFraction", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoreFraction
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cores", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cores
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Gpus
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Memory
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateResources\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateResources? InternalValue
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateResources?>();
            set => SetInstanceProperty(value);
        }
    }
}
