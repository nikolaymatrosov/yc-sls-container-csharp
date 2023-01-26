using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexKubernetesCluster
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/kubernetes_cluster yandex_kubernetes_cluster}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexKubernetesCluster.DataYandexKubernetesCluster), fullyQualifiedName: "yandex.dataYandexKubernetesCluster.DataYandexKubernetesCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.dataYandexKubernetesCluster.DataYandexKubernetesClusterConfig\"}}]")]
    public class DataYandexKubernetesCluster : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/kubernetes_cluster yandex_kubernetes_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexKubernetesCluster(Constructs.Construct scope, string id, yandex.DataYandexKubernetesCluster.IDataYandexKubernetesClusterConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexKubernetesCluster.IDataYandexKubernetesClusterConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexKubernetesCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexKubernetesCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetClusterId")]
        public virtual void ResetClusterId()
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

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
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
        = GetStaticProperty<string>(typeof(yandex.DataYandexKubernetesCluster.DataYandexKubernetesCluster))!;

        [JsiiProperty(name: "clusterIpv4Range", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterIpv4Range
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clusterIpv6Range", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterIpv6Range
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "health", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Health
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "kmsProvider", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesCluster.DataYandexKubernetesClusterKmsProviderList\"}")]
        public virtual yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterKmsProviderList KmsProvider
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterKmsProviderList>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "logGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "master", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesCluster.DataYandexKubernetesClusterMasterList\"}")]
        public virtual yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterList Master
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterList>()!;
        }

        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkImplementation", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesCluster.DataYandexKubernetesClusterNetworkImplementationList\"}")]
        public virtual yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterNetworkImplementationList NetworkImplementation
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterNetworkImplementationList>()!;
        }

        [JsiiProperty(name: "networkPolicyProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkPolicyProvider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nodeIpv4CidrMaskSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NodeIpv4CidrMaskSize
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "nodeServiceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NodeServiceAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "releaseChannel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReleaseChannel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceIpv4Range", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceIpv4Range
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "serviceIpv6Range", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceIpv6Range
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
