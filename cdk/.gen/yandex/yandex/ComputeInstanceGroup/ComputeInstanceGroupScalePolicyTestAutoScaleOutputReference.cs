using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiClass(nativeType: typeof(yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScaleOutputReference), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScaleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ComputeInstanceGroupScalePolicyTestAutoScaleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ComputeInstanceGroupScalePolicyTestAutoScaleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ComputeInstanceGroupScalePolicyTestAutoScaleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeInstanceGroupScalePolicyTestAutoScaleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScaleCustomRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScaleCustomRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScaleCustomRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScaleCustomRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCpuUtilizationTarget")]
        public virtual void ResetCpuUtilizationTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomRule")]
        public virtual void ResetCustomRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxSize")]
        public virtual void ResetMaxSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinZoneSize")]
        public virtual void ResetMinZoneSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStabilizationDuration")]
        public virtual void ResetStabilizationDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWarmupDuration")]
        public virtual void ResetWarmupDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customRule", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleList\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleList CustomRule
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScaleCustomRuleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cpuUtilizationTargetInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CpuUtilizationTargetInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScaleCustomRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InitialSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "measurementDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MeasurementDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minZoneSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinZoneSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stabilizationDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StabilizationDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "warmupDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WarmupDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "cpuUtilizationTarget", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CpuUtilizationTarget
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "measurementDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MeasurementDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minZoneSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinZoneSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "stabilizationDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StabilizationDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "warmupDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double WarmupDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScale\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScale? InternalValue
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScale?>();
            set => SetInstanceProperty(value);
        }
    }
}
