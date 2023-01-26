using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeDisk
{
    [JsiiInterface(nativeType: typeof(IDataYandexComputeDiskDiskPlacementPolicy), fullyQualifiedName: "yandex.dataYandexComputeDisk.DataYandexComputeDiskDiskPlacementPolicy")]
    public interface IDataYandexComputeDiskDiskPlacementPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_disk#disk_placement_group_id DataYandexComputeDisk#disk_placement_group_id}.</summary>
        [JsiiProperty(name: "diskPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string DiskPlacementGroupId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexComputeDiskDiskPlacementPolicy), fullyQualifiedName: "yandex.dataYandexComputeDisk.DataYandexComputeDiskDiskPlacementPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexComputeDisk.IDataYandexComputeDiskDiskPlacementPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_disk#disk_placement_group_id DataYandexComputeDisk#disk_placement_group_id}.</summary>
            [JsiiProperty(name: "diskPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string DiskPlacementGroupId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
