using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeDisk
{
    [JsiiInterface(nativeType: typeof(IComputeDiskDiskPlacementPolicy), fullyQualifiedName: "yandex.computeDisk.ComputeDiskDiskPlacementPolicy")]
    public interface IComputeDiskDiskPlacementPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_disk#disk_placement_group_id ComputeDisk#disk_placement_group_id}.</summary>
        [JsiiProperty(name: "diskPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string DiskPlacementGroupId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeDiskDiskPlacementPolicy), fullyQualifiedName: "yandex.computeDisk.ComputeDiskDiskPlacementPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeDisk.IComputeDiskDiskPlacementPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_disk#disk_placement_group_id ComputeDisk#disk_placement_group_id}.</summary>
            [JsiiProperty(name: "diskPlacementGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string DiskPlacementGroupId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
