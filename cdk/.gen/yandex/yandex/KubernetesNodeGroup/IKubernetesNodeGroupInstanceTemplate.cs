using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiInterface(nativeType: typeof(IKubernetesNodeGroupInstanceTemplate), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplate")]
    public interface IKubernetesNodeGroupInstanceTemplate
    {
        /// <summary>boot_disk block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#boot_disk KubernetesNodeGroup#boot_disk}
        /// </remarks>
        [JsiiProperty(name: "bootDisk", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateBootDisk\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateBootDisk? BootDisk
        {
            get
            {
                return null;
            }
        }

        /// <summary>container_runtime block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#container_runtime KubernetesNodeGroup#container_runtime}
        /// </remarks>
        [JsiiProperty(name: "containerRuntime", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateContainerRuntime\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateContainerRuntime? ContainerRuntime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#labels KubernetesNodeGroup#labels}.</summary>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#metadata KubernetesNodeGroup#metadata}.</summary>
        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#name KubernetesNodeGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#nat KubernetesNodeGroup#nat}.</summary>
        [JsiiProperty(name: "nat", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Nat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#network_acceleration_type KubernetesNodeGroup#network_acceleration_type}.</summary>
        [JsiiProperty(name: "networkAccelerationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetworkAccelerationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>network_interface block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#network_interface KubernetesNodeGroup#network_interface}
        /// </remarks>
        [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NetworkInterface
        {
            get
            {
                return null;
            }
        }

        /// <summary>placement_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#placement_policy KubernetesNodeGroup#placement_policy}
        /// </remarks>
        [JsiiProperty(name: "placementPolicy", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplatePlacementPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplatePlacementPolicy? PlacementPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#platform_id KubernetesNodeGroup#platform_id}.</summary>
        [JsiiProperty(name: "platformId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlatformId
        {
            get
            {
                return null;
            }
        }

        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#resources KubernetesNodeGroup#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateResources\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateResources? Resources
        {
            get
            {
                return null;
            }
        }

        /// <summary>scheduling_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#scheduling_policy KubernetesNodeGroup#scheduling_policy}
        /// </remarks>
        [JsiiProperty(name: "schedulingPolicy", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateSchedulingPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateSchedulingPolicy? SchedulingPolicy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesNodeGroupInstanceTemplate), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplate")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>boot_disk block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#boot_disk KubernetesNodeGroup#boot_disk}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bootDisk", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateBootDisk\"}", isOptional: true)]
            public yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateBootDisk? BootDisk
            {
                get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateBootDisk?>();
            }

            /// <summary>container_runtime block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#container_runtime KubernetesNodeGroup#container_runtime}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "containerRuntime", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateContainerRuntime\"}", isOptional: true)]
            public yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateContainerRuntime? ContainerRuntime
            {
                get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateContainerRuntime?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#labels KubernetesNodeGroup#labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Labels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#metadata KubernetesNodeGroup#metadata}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Metadata
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#name KubernetesNodeGroup#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#nat KubernetesNodeGroup#nat}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nat", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Nat
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#network_acceleration_type KubernetesNodeGroup#network_acceleration_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "networkAccelerationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetworkAccelerationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>network_interface block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#network_interface KubernetesNodeGroup#network_interface}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "networkInterface", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NetworkInterface
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>placement_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#placement_policy KubernetesNodeGroup#placement_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "placementPolicy", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplatePlacementPolicy\"}", isOptional: true)]
            public yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplatePlacementPolicy? PlacementPolicy
            {
                get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplatePlacementPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#platform_id KubernetesNodeGroup#platform_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "platformId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlatformId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#resources KubernetesNodeGroup#resources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateResources\"}", isOptional: true)]
            public yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateResources? Resources
            {
                get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateResources?>();
            }

            /// <summary>scheduling_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#scheduling_policy KubernetesNodeGroup#scheduling_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedulingPolicy", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateSchedulingPolicy\"}", isOptional: true)]
            public yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateSchedulingPolicy? SchedulingPolicy
            {
                get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateSchedulingPolicy?>();
            }
        }
    }
}
