using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexKubernetesNodeGroup
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/kubernetes_node_group yandex_kubernetes_node_group}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroup), fullyQualifiedName: "yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupConfig\"}}]")]
    public class DataYandexKubernetesNodeGroup : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/kubernetes_node_group yandex_kubernetes_node_group} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexKubernetesNodeGroup(Constructs.Construct scope, string id, yandex.DataYandexKubernetesNodeGroup.IDataYandexKubernetesNodeGroupConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexKubernetesNodeGroup.IDataYandexKubernetesNodeGroupConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexKubernetesNodeGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexKubernetesNodeGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFolderId")]
        public virtual void ResetFolderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeGroupId")]
        public virtual void ResetNodeGroupId()
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
        = GetStaticProperty<string>(typeof(yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroup))!;

        [JsiiProperty(name: "allocationPolicy", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupAllocationPolicyList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupAllocationPolicyList AllocationPolicy
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupAllocationPolicyList>()!;
        }

        [JsiiProperty(name: "allowedUnsafeSysctls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedUnsafeSysctls
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployPolicy", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupDeployPolicyList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupDeployPolicyList DeployPolicy
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupDeployPolicyList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceTemplate", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateList InstanceTemplate
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupInstanceTemplateList>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupMaintenancePolicyList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupMaintenancePolicyList MaintenancePolicy
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupMaintenancePolicyList>()!;
        }

        [JsiiProperty(name: "nodeLabels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap NodeLabels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "nodeTaints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NodeTaints
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scalePolicy", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyList ScalePolicy
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionInfo", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupVersionInfoList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupVersionInfoList VersionInfo
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupVersionInfoList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "folderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FolderIdInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FolderId
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
