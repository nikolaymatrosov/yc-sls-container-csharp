using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    [JsiiByValue(fqn: "yandex.kubernetesCluster.KubernetesClusterMaster")]
    public class KubernetesClusterMaster : yandex.KubernetesCluster.IKubernetesClusterMaster
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#external_v6_address KubernetesCluster#external_v6_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "externalV6Address", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalV6Address
        {
            get;
            set;
        }

        /// <summary>maintenance_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#maintenance_policy KubernetesCluster#maintenance_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicy\"}", isOptional: true)]
        public yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicy? MaintenancePolicy
        {
            get;
            set;
        }

        private object? _publicIp;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#public_ip KubernetesCluster#public_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "publicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? PublicIp
        {
            get => _publicIp;
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
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _publicIp = value;
            }
        }

        /// <summary>regional block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#regional KubernetesCluster#regional}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regional", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterRegional\"}", isOptional: true)]
        public yandex.KubernetesCluster.IKubernetesClusterMasterRegional? Regional
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#security_group_ids KubernetesCluster#security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#version KubernetesCluster#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }

        /// <summary>zonal block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#zonal KubernetesCluster#zonal}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zonal", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterMasterZonal\"}", isOptional: true)]
        public yandex.KubernetesCluster.IKubernetesClusterMasterZonal? Zonal
        {
            get;
            set;
        }
    }
}
