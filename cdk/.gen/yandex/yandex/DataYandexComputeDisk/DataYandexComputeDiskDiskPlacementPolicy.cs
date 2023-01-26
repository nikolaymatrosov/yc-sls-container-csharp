using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeDisk
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataYandexComputeDisk.DataYandexComputeDiskDiskPlacementPolicy")]
    public class DataYandexComputeDiskDiskPlacementPolicy : yandex.DataYandexComputeDisk.IDataYandexComputeDiskDiskPlacementPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_disk#disk_placement_group_id DataYandexComputeDisk#disk_placement_group_id}.</summary>
        [JsiiProperty(name: "diskPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string DiskPlacementGroupId
        {
            get;
            set;
        }
    }
}
