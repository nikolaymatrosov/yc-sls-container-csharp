using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplatePlacementPolicy")]
    public class KubernetesNodeGroupInstanceTemplatePlacementPolicy : yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplatePlacementPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#placement_group_id KubernetesNodeGroup#placement_group_id}.</summary>
        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string PlacementGroupId
        {
            get;
            set;
        }
    }
}
