using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterConfig), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterConfig")]
    public interface IKubernetesClusterConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>master block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#master KubernetesCluster#master}
        /// </remarks>
        [JsiiProperty(name: "master", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMaster\"}")]
        yandex.KubernetesCluster.IKubernetesClusterMaster Master
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#network_id KubernetesCluster#network_id}.</summary>
        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#node_service_account_id KubernetesCluster#node_service_account_id}.</summary>
        [JsiiProperty(name: "nodeServiceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string NodeServiceAccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#service_account_id KubernetesCluster#service_account_id}.</summary>
        [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceAccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#cluster_ipv4_range KubernetesCluster#cluster_ipv4_range}.</summary>
        [JsiiProperty(name: "clusterIpv4Range", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterIpv4Range
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#cluster_ipv6_range KubernetesCluster#cluster_ipv6_range}.</summary>
        [JsiiProperty(name: "clusterIpv6Range", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClusterIpv6Range
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#description KubernetesCluster#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#folder_id KubernetesCluster#folder_id}.</summary>
        [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FolderId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#id KubernetesCluster#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>kms_provider block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#kms_provider KubernetesCluster#kms_provider}
        /// </remarks>
        [JsiiProperty(name: "kmsProvider", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterKmsProvider\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesCluster.IKubernetesClusterKmsProvider? KmsProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#labels KubernetesCluster#labels}.</summary>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#name KubernetesCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_implementation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#network_implementation KubernetesCluster#network_implementation}
        /// </remarks>
        [JsiiProperty(name: "networkImplementation", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation? NetworkImplementation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#network_policy_provider KubernetesCluster#network_policy_provider}.</summary>
        [JsiiProperty(name: "networkPolicyProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkPolicyProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#node_ipv4_cidr_mask_size KubernetesCluster#node_ipv4_cidr_mask_size}.</summary>
        [JsiiProperty(name: "nodeIpv4CidrMaskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NodeIpv4CidrMaskSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#release_channel KubernetesCluster#release_channel}.</summary>
        [JsiiProperty(name: "releaseChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReleaseChannel
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#service_ipv4_range KubernetesCluster#service_ipv4_range}.</summary>
        [JsiiProperty(name: "serviceIpv4Range", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceIpv4Range
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#service_ipv6_range KubernetesCluster#service_ipv6_range}.</summary>
        [JsiiProperty(name: "serviceIpv6Range", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceIpv6Range
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#timeouts KubernetesCluster#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesCluster.IKubernetesClusterTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterConfig), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesCluster.IKubernetesClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>master block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#master KubernetesCluster#master}
            /// </remarks>
            [JsiiProperty(name: "master", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMaster\"}")]
            public yandex.KubernetesCluster.IKubernetesClusterMaster Master
            {
                get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterMaster>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#network_id KubernetesCluster#network_id}.</summary>
            [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#node_service_account_id KubernetesCluster#node_service_account_id}.</summary>
            [JsiiProperty(name: "nodeServiceAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeServiceAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#service_account_id KubernetesCluster#service_account_id}.</summary>
            [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#cluster_ipv4_range KubernetesCluster#cluster_ipv4_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterIpv4Range", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterIpv4Range
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#cluster_ipv6_range KubernetesCluster#cluster_ipv6_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clusterIpv6Range", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClusterIpv6Range
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#description KubernetesCluster#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#folder_id KubernetesCluster#folder_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FolderId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#id KubernetesCluster#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>kms_provider block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#kms_provider KubernetesCluster#kms_provider}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kmsProvider", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterKmsProvider\"}", isOptional: true)]
            public yandex.KubernetesCluster.IKubernetesClusterKmsProvider? KmsProvider
            {
                get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterKmsProvider?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#labels KubernetesCluster#labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Labels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#name KubernetesCluster#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_implementation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#network_implementation KubernetesCluster#network_implementation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkImplementation", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementation\"}", isOptional: true)]
            public yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation? NetworkImplementation
            {
                get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#network_policy_provider KubernetesCluster#network_policy_provider}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkPolicyProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkPolicyProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#node_ipv4_cidr_mask_size KubernetesCluster#node_ipv4_cidr_mask_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeIpv4CidrMaskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NodeIpv4CidrMaskSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#release_channel KubernetesCluster#release_channel}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "releaseChannel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReleaseChannel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#service_ipv4_range KubernetesCluster#service_ipv4_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceIpv4Range", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceIpv4Range
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#service_ipv6_range KubernetesCluster#service_ipv6_range}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceIpv6Range", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceIpv6Range
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#timeouts KubernetesCluster#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterTimeouts\"}", isOptional: true)]
            public yandex.KubernetesCluster.IKubernetesClusterTimeouts? Timeouts
            {
                get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
