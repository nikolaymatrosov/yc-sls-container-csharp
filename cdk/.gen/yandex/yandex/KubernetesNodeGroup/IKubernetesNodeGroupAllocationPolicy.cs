using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiInterface(nativeType: typeof(IKubernetesNodeGroupAllocationPolicy), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupAllocationPolicy")]
    public interface IKubernetesNodeGroupAllocationPolicy
    {
        /// <summary>location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#location KubernetesNodeGroup#location}
        /// </remarks>
        [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupAllocationPolicyLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Location
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesNodeGroupAllocationPolicy), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupAllocationPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesNodeGroup.IKubernetesNodeGroupAllocationPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#location KubernetesNodeGroup#location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "location", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupAllocationPolicyLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Location
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
