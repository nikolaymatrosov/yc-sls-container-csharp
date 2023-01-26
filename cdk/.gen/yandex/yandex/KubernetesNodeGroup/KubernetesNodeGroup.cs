using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group yandex_kubernetes_node_group}.</summary>
    [JsiiClass(nativeType: typeof(yandex.KubernetesNodeGroup.KubernetesNodeGroup), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupConfig\"}}]")]
    public class KubernetesNodeGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group yandex_kubernetes_node_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KubernetesNodeGroup(Constructs.Construct scope, string id, yandex.KubernetesNodeGroup.IKubernetesNodeGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.KubernetesNodeGroup.IKubernetesNodeGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesNodeGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesNodeGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllocationPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupAllocationPolicy\"}}]")]
        public virtual void PutAllocationPolicy(yandex.KubernetesNodeGroup.IKubernetesNodeGroupAllocationPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesNodeGroup.IKubernetesNodeGroupAllocationPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeployPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupDeployPolicy\"}}]")]
        public virtual void PutDeployPolicy(yandex.KubernetesNodeGroup.IKubernetesNodeGroupDeployPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesNodeGroup.IKubernetesNodeGroupDeployPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplate\"}}]")]
        public virtual void PutInstanceTemplate(yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenancePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupMaintenancePolicy\"}}]")]
        public virtual void PutMaintenancePolicy(yandex.KubernetesNodeGroup.IKubernetesNodeGroupMaintenancePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesNodeGroup.IKubernetesNodeGroupMaintenancePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicy\"}}]")]
        public virtual void PutScalePolicy(yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.KubernetesNodeGroup.IKubernetesNodeGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesNodeGroup.IKubernetesNodeGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllocationPolicy")]
        public virtual void ResetAllocationPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedUnsafeSysctls")]
        public virtual void ResetAllowedUnsafeSysctls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeployPolicy")]
        public virtual void ResetDeployPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenancePolicy")]
        public virtual void ResetMaintenancePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeLabels")]
        public virtual void ResetNodeLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeTaints")]
        public virtual void ResetNodeTaints()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(yandex.KubernetesNodeGroup.KubernetesNodeGroup))!;

        [JsiiProperty(name: "allocationPolicy", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupAllocationPolicyOutputReference\"}")]
        public virtual yandex.KubernetesNodeGroup.KubernetesNodeGroupAllocationPolicyOutputReference AllocationPolicy
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.KubernetesNodeGroupAllocationPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployPolicy", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupDeployPolicyOutputReference\"}")]
        public virtual yandex.KubernetesNodeGroup.KubernetesNodeGroupDeployPolicyOutputReference DeployPolicy
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.KubernetesNodeGroupDeployPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "instanceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceTemplate", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateOutputReference\"}")]
        public virtual yandex.KubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateOutputReference InstanceTemplate
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupMaintenancePolicyOutputReference\"}")]
        public virtual yandex.KubernetesNodeGroup.KubernetesNodeGroupMaintenancePolicyOutputReference MaintenancePolicy
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.KubernetesNodeGroupMaintenancePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "scalePolicy", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyOutputReference\"}")]
        public virtual yandex.KubernetesNodeGroup.KubernetesNodeGroupScalePolicyOutputReference ScalePolicy
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.KubernetesNodeGroupScalePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupTimeoutsOutputReference\"}")]
        public virtual yandex.KubernetesNodeGroup.KubernetesNodeGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.KubernetesNodeGroupTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "versionInfo", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupVersionInfoList\"}")]
        public virtual yandex.KubernetesNodeGroup.KubernetesNodeGroupVersionInfoList VersionInfo
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.KubernetesNodeGroupVersionInfoList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationPolicyInput", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupAllocationPolicy\"}", isOptional: true)]
        public virtual yandex.KubernetesNodeGroup.IKubernetesNodeGroupAllocationPolicy? AllocationPolicyInput
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupAllocationPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedUnsafeSysctlsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedUnsafeSysctlsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployPolicyInput", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupDeployPolicy\"}", isOptional: true)]
        public virtual yandex.KubernetesNodeGroup.IKubernetesNodeGroupDeployPolicy? DeployPolicyInput
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupDeployPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTemplateInput", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplate\"}", isOptional: true)]
        public virtual yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplate? InstanceTemplateInput
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenancePolicyInput", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupMaintenancePolicy\"}", isOptional: true)]
        public virtual yandex.KubernetesNodeGroup.IKubernetesNodeGroupMaintenancePolicy? MaintenancePolicyInput
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupMaintenancePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeLabelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? NodeLabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeTaintsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NodeTaintsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalePolicyInput", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicy\"}", isOptional: true)]
        public virtual yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicy? ScalePolicyInput
        {
            get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowedUnsafeSysctls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedUnsafeSysctls
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> NodeLabels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeTaints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NodeTaints
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
    }
}
