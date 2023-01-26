using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterNetworkImplementation), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterNetworkImplementation")]
    public interface IKubernetesClusterNetworkImplementation
    {
        /// <summary>cilium block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#cilium KubernetesCluster#cilium}
        /// </remarks>
        [JsiiProperty(name: "cilium", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementationCilium\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesCluster.IKubernetesClusterNetworkImplementationCilium? Cilium
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterNetworkImplementation), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterNetworkImplementation")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cilium block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#cilium KubernetesCluster#cilium}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cilium", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementationCilium\"}", isOptional: true)]
            public yandex.KubernetesCluster.IKubernetesClusterNetworkImplementationCilium? Cilium
            {
                get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterNetworkImplementationCilium?>();
            }
        }
    }
}
