using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.computeInstanceGroup.ComputeInstanceGroupAllocationPolicy")]
    public class ComputeInstanceGroupAllocationPolicy : yandex.ComputeInstanceGroup.IComputeInstanceGroupAllocationPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#zones ComputeInstanceGroup#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Zones
        {
            get;
            set;
        }
    }
}
