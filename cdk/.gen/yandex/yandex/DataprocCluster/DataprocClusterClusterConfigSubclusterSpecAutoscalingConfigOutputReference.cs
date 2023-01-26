using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataprocCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfigOutputReference), fullyQualifiedName: "yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataprocClusterClusterConfigSubclusterSpecAutoscalingConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataprocClusterClusterConfigSubclusterSpecAutoscalingConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataprocClusterClusterConfigSubclusterSpecAutoscalingConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataprocClusterClusterConfigSubclusterSpecAutoscalingConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCpuUtilizationTarget")]
        public virtual void ResetCpuUtilizationTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDecommissionTimeout")]
        public virtual void ResetDecommissionTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMeasurementDuration")]
        public virtual void ResetMeasurementDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreemptible")]
        public virtual void ResetPreemptible()
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

        [JsiiOptional]
        [JsiiProperty(name: "cpuUtilizationTargetInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CpuUtilizationTargetInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "decommissionTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DecommissionTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxHostsCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxHostsCountInput
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
        [JsiiProperty(name: "preemptibleInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PreemptibleInput
        {
            get => GetInstanceProperty<object?>();
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

        [JsiiProperty(name: "decommissionTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DecommissionTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxHostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxHostsCount
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

        [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Preemptible
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig\"}", isOptional: true)]
        public virtual yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig? InternalValue
        {
            get => GetInstanceProperty<yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
