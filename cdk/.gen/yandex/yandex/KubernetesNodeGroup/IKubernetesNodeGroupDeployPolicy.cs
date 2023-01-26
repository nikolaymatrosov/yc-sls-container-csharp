using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiInterface(nativeType: typeof(IKubernetesNodeGroupDeployPolicy), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupDeployPolicy")]
    public interface IKubernetesNodeGroupDeployPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#max_expansion KubernetesNodeGroup#max_expansion}.</summary>
        [JsiiProperty(name: "maxExpansion", typeJson: "{\"primitive\":\"number\"}")]
        double MaxExpansion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#max_unavailable KubernetesNodeGroup#max_unavailable}.</summary>
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}")]
        double MaxUnavailable
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesNodeGroupDeployPolicy), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupDeployPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesNodeGroup.IKubernetesNodeGroupDeployPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#max_expansion KubernetesNodeGroup#max_expansion}.</summary>
            [JsiiProperty(name: "maxExpansion", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxExpansion
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#max_unavailable KubernetesNodeGroup#max_unavailable}.</summary>
            [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxUnavailable
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
