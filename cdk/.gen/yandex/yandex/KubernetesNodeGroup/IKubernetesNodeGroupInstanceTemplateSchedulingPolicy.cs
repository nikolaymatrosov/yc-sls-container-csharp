using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiInterface(nativeType: typeof(IKubernetesNodeGroupInstanceTemplateSchedulingPolicy), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateSchedulingPolicy")]
    public interface IKubernetesNodeGroupInstanceTemplateSchedulingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#preemptible KubernetesNodeGroup#preemptible}.</summary>
        [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Preemptible
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesNodeGroupInstanceTemplateSchedulingPolicy), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateSchedulingPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateSchedulingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#preemptible KubernetesNodeGroup#preemptible}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Preemptible
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
