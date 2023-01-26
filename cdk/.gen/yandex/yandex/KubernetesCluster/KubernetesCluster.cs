using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster yandex_kubernetes_cluster}.</summary>
    [JsiiClass(nativeType: typeof(yandex.KubernetesCluster.KubernetesCluster), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterConfig\"}}]")]
    public class KubernetesCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster yandex_kubernetes_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KubernetesCluster(Constructs.Construct scope, string id, yandex.KubernetesCluster.IKubernetesClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.KubernetesCluster.IKubernetesClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKmsProvider", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterKmsProvider\"}}]")]
        public virtual void PutKmsProvider(yandex.KubernetesCluster.IKubernetesClusterKmsProvider @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesCluster.IKubernetesClusterKmsProvider)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMaster\"}}]")]
        public virtual void PutMaster(yandex.KubernetesCluster.IKubernetesClusterMaster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesCluster.IKubernetesClusterMaster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkImplementation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementation\"}}]")]
        public virtual void PutNetworkImplementation(yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.KubernetesCluster.IKubernetesClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesCluster.IKubernetesClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClusterIpv4Range")]
        public virtual void ResetClusterIpv4Range()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterIpv6Range")]
        public virtual void ResetClusterIpv6Range()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiMethod(name: "resetKmsProvider")]
        public virtual void ResetKmsProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkImplementation")]
        public virtual void ResetNetworkImplementation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkPolicyProvider")]
        public virtual void ResetNetworkPolicyProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNodeIpv4CidrMaskSize")]
        public virtual void ResetNodeIpv4CidrMaskSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReleaseChannel")]
        public virtual void ResetReleaseChannel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceIpv4Range")]
        public virtual void ResetServiceIpv4Range()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceIpv6Range")]
        public virtual void ResetServiceIpv6Range()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(yandex.KubernetesCluster.KubernetesCluster))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "health", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Health
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsProvider", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterKmsProviderOutputReference\"}")]
        public virtual yandex.KubernetesCluster.KubernetesClusterKmsProviderOutputReference KmsProvider
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.KubernetesClusterKmsProviderOutputReference>()!;
        }

        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "master", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterOutputReference\"}")]
        public virtual yandex.KubernetesCluster.KubernetesClusterMasterOutputReference Master
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.KubernetesClusterMasterOutputReference>()!;
        }

        [JsiiProperty(name: "networkImplementation", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementationOutputReference\"}")]
        public virtual yandex.KubernetesCluster.KubernetesClusterNetworkImplementationOutputReference NetworkImplementation
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.KubernetesClusterNetworkImplementationOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterTimeoutsOutputReference\"}")]
        public virtual yandex.KubernetesCluster.KubernetesClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.KubernetesClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIpv4RangeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIpv4RangeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIpv6RangeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIpv6RangeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
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
        [JsiiProperty(name: "kmsProviderInput", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterKmsProvider\"}", isOptional: true)]
        public virtual yandex.KubernetesCluster.IKubernetesClusterKmsProvider? KmsProviderInput
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterKmsProvider?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterInput", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMaster\"}", isOptional: true)]
        public virtual yandex.KubernetesCluster.IKubernetesClusterMaster? MasterInput
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterMaster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkImplementationInput", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementation\"}", isOptional: true)]
        public virtual yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation? NetworkImplementationInput
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkPolicyProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkPolicyProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeIpv4CidrMaskSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? NodeIpv4CidrMaskSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nodeServiceAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NodeServiceAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "releaseChannelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReleaseChannelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceIpv4RangeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceIpv4RangeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceIpv6RangeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceIpv6RangeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "clusterIpv4Range", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterIpv4Range
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clusterIpv6Range", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterIpv6Range
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

        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkPolicyProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkPolicyProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeIpv4CidrMaskSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeIpv4CidrMaskSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nodeServiceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeServiceAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "releaseChannel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseChannel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceIpv4Range", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceIpv4Range
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceIpv6Range", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceIpv6Range
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
