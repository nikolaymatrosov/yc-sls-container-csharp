using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceGroupInstanceTemplatePlacementPolicy), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplatePlacementPolicy")]
    public interface IComputeInstanceGroupInstanceTemplatePlacementPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#placement_group_id ComputeInstanceGroup#placement_group_id}.</summary>
        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        string PlacementGroupId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceGroupInstanceTemplatePlacementPolicy), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplatePlacementPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplatePlacementPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#placement_group_id ComputeInstanceGroup#placement_group_id}.</summary>
            [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}")]
            public string PlacementGroupId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
