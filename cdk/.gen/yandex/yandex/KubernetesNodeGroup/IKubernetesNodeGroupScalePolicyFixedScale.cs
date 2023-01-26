using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiInterface(nativeType: typeof(IKubernetesNodeGroupScalePolicyFixedScale), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyFixedScale")]
    public interface IKubernetesNodeGroupScalePolicyFixedScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#size KubernetesNodeGroup#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Size
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesNodeGroupScalePolicyFixedScale), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyFixedScale")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyFixedScale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#size KubernetesNodeGroup#size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Size
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
