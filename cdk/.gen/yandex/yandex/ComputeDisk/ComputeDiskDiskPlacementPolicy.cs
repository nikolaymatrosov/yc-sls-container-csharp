using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeDisk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.computeDisk.ComputeDiskDiskPlacementPolicy")]
    public class ComputeDiskDiskPlacementPolicy : yandex.ComputeDisk.IComputeDiskDiskPlacementPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_disk#disk_placement_group_id ComputeDisk#disk_placement_group_id}.</summary>
        [JsiiProperty(name: "diskPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string DiskPlacementGroupId
        {
            get;
            set;
        }
    }
}
