using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceGroupAllocationPolicy), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupAllocationPolicy")]
    public interface IComputeInstanceGroupAllocationPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#zones ComputeInstanceGroup#zones}.</summary>
        [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Zones
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceGroupAllocationPolicy), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupAllocationPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstanceGroup.IComputeInstanceGroupAllocationPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#zones ComputeInstanceGroup#zones}.</summary>
            [JsiiProperty(name: "zones", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Zones
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
