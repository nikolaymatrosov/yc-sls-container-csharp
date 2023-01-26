using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiByValue(fqn: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplate")]
    public class KubernetesNodeGroupInstanceTemplate : yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplate
    {
        /// <summary>boot_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#boot_disk KubernetesNodeGroup#boot_disk}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bootDisk", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateBootDisk\"}", isOptional: true)]
        public yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateBootDisk? BootDisk
        {
            get;
            set;
        }

        /// <summary>container_runtime block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#container_runtime KubernetesNodeGroup#container_runtime}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerRuntime", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateContainerRuntime\"}", isOptional: true)]
        public yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateContainerRuntime? ContainerRuntime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#labels KubernetesNodeGroup#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#metadata KubernetesNodeGroup#metadata}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#name KubernetesNodeGroup#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        private object? _nat;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#nat KubernetesNodeGroup#nat}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nat", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Nat
        {
            get => _nat;
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
                _nat = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#network_acceleration_type KubernetesNodeGroup#network_acceleration_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "networkAccelerationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NetworkAccelerationType
        {
            get;
            set;
        }

        private object? _networkInterface;

        /// <summary>network_interface block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#network_interface KubernetesNodeGroup#network_interface}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? NetworkInterface
        {
            get => _networkInterface;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateNetworkInterface[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateNetworkInterface).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _networkInterface = value;
            }
        }

        /// <summary>placement_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#placement_policy KubernetesNodeGroup#placement_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "placementPolicy", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplatePlacementPolicy\"}", isOptional: true)]
        public yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplatePlacementPolicy? PlacementPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#platform_id KubernetesNodeGroup#platform_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "platformId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlatformId
        {
            get;
            set;
        }

        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#resources KubernetesNodeGroup#resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateResources\"}", isOptional: true)]
        public yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateResources? Resources
        {
            get;
            set;
        }

        /// <summary>scheduling_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#scheduling_policy KubernetesNodeGroup#scheduling_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schedulingPolicy", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateSchedulingPolicy\"}", isOptional: true)]
        public yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateSchedulingPolicy? SchedulingPolicy
        {
            get;
            set;
        }
    }
}
