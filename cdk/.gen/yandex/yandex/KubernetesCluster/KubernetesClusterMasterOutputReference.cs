using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(yandex.KubernetesCluster.KubernetesClusterMasterOutputReference), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterMasterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterMasterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterMasterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterMasterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterMasterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMaintenancePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicy\"}}]")]
        public virtual void PutMaintenancePolicy(yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegional", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterRegional\"}}]")]
        public virtual void PutRegional(yandex.KubernetesCluster.IKubernetesClusterMasterRegional @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesCluster.IKubernetesClusterMasterRegional)}, new object[]{@value});
        }

        [JsiiMethod(name: "putZonal", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterZonal\"}}]")]
        public virtual void PutZonal(yandex.KubernetesCluster.IKubernetesClusterMasterZonal @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesCluster.IKubernetesClusterMasterZonal)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExternalV6Address")]
        public virtual void ResetExternalV6Address()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenancePolicy")]
        public virtual void ResetMaintenancePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPublicIp")]
        public virtual void ResetPublicIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegional")]
        public virtual void ResetRegional()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupIds")]
        public virtual void ResetSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZonal")]
        public virtual void ResetZonal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clusterCaCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterCaCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalV4Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalV4Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalV4Endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalV4Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalV6Endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalV6Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "internalV4Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalV4Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "internalV4Endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalV4Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicyOutputReference\"}")]
        public virtual yandex.KubernetesCluster.KubernetesClusterMasterMaintenancePolicyOutputReference MaintenancePolicy
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.KubernetesClusterMasterMaintenancePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "regional", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterRegionalOutputReference\"}")]
        public virtual yandex.KubernetesCluster.KubernetesClusterMasterRegionalOutputReference Regional
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.KubernetesClusterMasterRegionalOutputReference>()!;
        }

        [JsiiProperty(name: "versionInfo", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterVersionInfoList\"}")]
        public virtual yandex.KubernetesCluster.KubernetesClusterMasterVersionInfoList VersionInfo
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.KubernetesClusterMasterVersionInfoList>()!;
        }

        [JsiiProperty(name: "zonal", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterZonalOutputReference\"}")]
        public virtual yandex.KubernetesCluster.KubernetesClusterMasterZonalOutputReference Zonal
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.KubernetesClusterMasterZonalOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalV6AddressInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExternalV6AddressInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenancePolicyInput", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicy\"}", isOptional: true)]
        public virtual yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicy? MaintenancePolicyInput
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicIpInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? PublicIpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionalInput", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterRegional\"}", isOptional: true)]
        public virtual yandex.KubernetesCluster.IKubernetesClusterMasterRegional? RegionalInput
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterMasterRegional?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zonalInput", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterZonal\"}", isOptional: true)]
        public virtual yandex.KubernetesCluster.IKubernetesClusterMasterZonal? ZonalInput
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterMasterZonal?>();
        }

        [JsiiProperty(name: "externalV6Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalV6Address
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object PublicIp
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

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMaster\"}", isOptional: true)]
        public virtual yandex.KubernetesCluster.IKubernetesClusterMaster? InternalValue
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterMaster?>();
            set => SetInstanceProperty(value);
        }
    }
}
