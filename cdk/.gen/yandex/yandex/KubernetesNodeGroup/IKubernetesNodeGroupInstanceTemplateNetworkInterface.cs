using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiInterface(nativeType: typeof(IKubernetesNodeGroupInstanceTemplateNetworkInterface), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateNetworkInterface")]
    public interface IKubernetesNodeGroupInstanceTemplateNetworkInterface
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#subnet_ids KubernetesNodeGroup#subnet_ids}.</summary>
        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SubnetIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#ipv4 KubernetesNodeGroup#ipv4}.</summary>
        [JsiiProperty(name: "ipv4", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv4
        {
            get
            {
                return null;
            }
        }

        /// <summary>ipv4_dns_records block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#ipv4_dns_records KubernetesNodeGroup#ipv4_dns_records}
        /// </remarks>
        [JsiiProperty(name: "ipv4DnsRecords", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateNetworkInterfaceIpv4DnsRecords\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv4DnsRecords
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#ipv6 KubernetesNodeGroup#ipv6}.</summary>
        [JsiiProperty(name: "ipv6", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv6
        {
            get
            {
                return null;
            }
        }

        /// <summary>ipv6_dns_records block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#ipv6_dns_records KubernetesNodeGroup#ipv6_dns_records}
        /// </remarks>
        [JsiiProperty(name: "ipv6DnsRecords", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateNetworkInterfaceIpv6DnsRecords\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ipv6DnsRecords
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#security_group_ids KubernetesNodeGroup#security_group_ids}.</summary>
        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroupIds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesNodeGroupInstanceTemplateNetworkInterface), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateNetworkInterface")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateNetworkInterface
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#subnet_ids KubernetesNodeGroup#subnet_ids}.</summary>
            [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SubnetIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#ipv4 KubernetesNodeGroup#ipv4}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Ipv4
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ipv4_dns_records block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#ipv4_dns_records KubernetesNodeGroup#ipv4_dns_records}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv4DnsRecords", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateNetworkInterfaceIpv4DnsRecords\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ipv4DnsRecords
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#ipv6 KubernetesNodeGroup#ipv6}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Ipv6
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ipv6_dns_records block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#ipv6_dns_records KubernetesNodeGroup#ipv6_dns_records}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ipv6DnsRecords", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateNetworkInterfaceIpv6DnsRecords\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Ipv6DnsRecords
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#nat KubernetesNodeGroup#nat}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nat", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Nat
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#security_group_ids KubernetesNodeGroup#security_group_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroupIds
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
