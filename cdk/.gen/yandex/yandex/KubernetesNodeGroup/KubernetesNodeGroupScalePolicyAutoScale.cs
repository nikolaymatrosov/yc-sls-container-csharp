using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyAutoScale")]
    public class KubernetesNodeGroupScalePolicyAutoScale : yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyAutoScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#initial KubernetesNodeGroup#initial}.</summary>
        [JsiiProperty(name: "initial", typeJson: "{\"primitive\":\"number\"}")]
        public double Initial
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#max KubernetesNodeGroup#max}.</summary>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}")]
        public double Max
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#min KubernetesNodeGroup#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}")]
        public double Min
        {
            get;
            set;
        }
    }
}
