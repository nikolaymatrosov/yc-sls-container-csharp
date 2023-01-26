using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(yandex.KubernetesCluster.KubernetesClusterMasterMaintenancePolicyOutputReference), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterMasterMaintenancePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterMasterMaintenancePolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterMasterMaintenancePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterMasterMaintenancePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMaintenanceWindow", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicyMaintenanceWindow\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutMaintenanceWindow(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicyMaintenanceWindow[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicyMaintenanceWindow).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicyMaintenanceWindow).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaintenanceWindow")]
        public virtual void ResetMaintenanceWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicyMaintenanceWindowList\"}")]
        public virtual yandex.KubernetesCluster.KubernetesClusterMasterMaintenancePolicyMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.KubernetesClusterMasterMaintenancePolicyMaintenanceWindowList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoUpgradeInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutoUpgradeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicyMaintenanceWindow\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? MaintenanceWindowInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "autoUpgrade", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AutoUpgrade
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicy\"}", isOptional: true)]
        public virtual yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicy? InternalValue
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
