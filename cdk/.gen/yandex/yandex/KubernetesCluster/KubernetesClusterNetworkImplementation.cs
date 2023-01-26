using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    [JsiiByValue(fqn: "yandex.kubernetesCluster.KubernetesClusterNetworkImplementation")]
    public class KubernetesClusterNetworkImplementation : yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation
    {
        /// <summary>cilium block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#cilium KubernetesCluster#cilium}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cilium", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementationCilium\"}", isOptional: true)]
        public yandex.KubernetesCluster.IKubernetesClusterNetworkImplementationCilium? Cilium
        {
            get;
            set;
        }
    }
}
