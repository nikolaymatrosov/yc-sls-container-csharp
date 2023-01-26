using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterMaster), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterMaster")]
    public interface IKubernetesClusterMaster
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#external_v6_address KubernetesCluster#external_v6_address}.</summary>
        [JsiiProperty(name: "externalV6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExternalV6Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>maintenance_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#maintenance_policy KubernetesCluster#maintenance_policy}
        /// </remarks>
        [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicy? MaintenancePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#public_ip KubernetesCluster#public_ip}.</summary>
        [JsiiProperty(name: "publicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PublicIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>regional block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#regional KubernetesCluster#regional}
        /// </remarks>
        [JsiiProperty(name: "regional", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterRegional\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesCluster.IKubernetesClusterMasterRegional? Regional
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#security_group_ids KubernetesCluster#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#version KubernetesCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>zonal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#zonal KubernetesCluster#zonal}
        /// </remarks>
        [JsiiProperty(name: "zonal", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterZonal\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesCluster.IKubernetesClusterMasterZonal? Zonal
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterMaster), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterMaster")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesCluster.IKubernetesClusterMaster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#external_v6_address KubernetesCluster#external_v6_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "externalV6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExternalV6Address
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>maintenance_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#maintenance_policy KubernetesCluster#maintenance_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicy\"}", isOptional: true)]
            public yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicy? MaintenancePolicy
            {
                get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#public_ip KubernetesCluster#public_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "publicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? PublicIp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>regional block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#regional KubernetesCluster#regional}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "regional", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterRegional\"}", isOptional: true)]
            public yandex.KubernetesCluster.IKubernetesClusterMasterRegional? Regional
            {
                get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterMasterRegional?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#security_group_ids KubernetesCluster#security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#version KubernetesCluster#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>zonal block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#zonal KubernetesCluster#zonal}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zonal", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterZonal\"}", isOptional: true)]
            public yandex.KubernetesCluster.IKubernetesClusterMasterZonal? Zonal
            {
                get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterMasterZonal?>();
            }
        }
    }
}
