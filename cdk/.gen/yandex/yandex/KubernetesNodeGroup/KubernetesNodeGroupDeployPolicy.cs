using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.kubernetesNodeGroup.KubernetesNodeGroupDeployPolicy")]
    public class KubernetesNodeGroupDeployPolicy : yandex.KubernetesNodeGroup.IKubernetesNodeGroupDeployPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#max_expansion KubernetesNodeGroup#max_expansion}.</summary>
        [JsiiProperty(name: "maxExpansion", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxExpansion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#max_unavailable KubernetesNodeGroup#max_unavailable}.</summary>
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxUnavailable
        {
            get;
            set;
        }
    }
}
