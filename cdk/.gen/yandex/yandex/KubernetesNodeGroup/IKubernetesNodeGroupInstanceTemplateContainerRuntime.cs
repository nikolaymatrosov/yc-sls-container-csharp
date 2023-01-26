using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiInterface(nativeType: typeof(IKubernetesNodeGroupInstanceTemplateContainerRuntime), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateContainerRuntime")]
    public interface IKubernetesNodeGroupInstanceTemplateContainerRuntime
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#type KubernetesNodeGroup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesNodeGroupInstanceTemplateContainerRuntime), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateContainerRuntime")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateContainerRuntime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#type KubernetesNodeGroup#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
