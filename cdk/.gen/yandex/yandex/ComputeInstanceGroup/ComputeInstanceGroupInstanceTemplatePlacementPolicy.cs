using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplatePlacementPolicy")]
    public class ComputeInstanceGroupInstanceTemplatePlacementPolicy : yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplatePlacementPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#placement_group_id ComputeInstanceGroup#placement_group_id}.</summary>
        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string PlacementGroupId
        {
            get;
            set;
        }
    }
}
