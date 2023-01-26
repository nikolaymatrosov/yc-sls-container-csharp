using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiByValue(fqn: "yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicy")]
    public class KubernetesNodeGroupScalePolicy : yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicy
    {
        /// <summary>auto_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#auto_scale KubernetesNodeGroup#auto_scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyAutoScale\"}", isOptional: true)]
        public yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyAutoScale? AutoScale
        {
            get;
            set;
        }

        /// <summary>fixed_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#fixed_scale KubernetesNodeGroup#fixed_scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyFixedScale\"}", isOptional: true)]
        public yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyFixedScale? FixedScale
        {
            get;
            set;
        }
    }
}
