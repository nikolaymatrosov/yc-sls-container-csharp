using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceLocalDisk), fullyQualifiedName: "yandex.computeInstance.ComputeInstanceLocalDisk")]
    public interface IComputeInstanceLocalDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#size_bytes ComputeInstance#size_bytes}.</summary>
        [JsiiProperty(name: "sizeBytes", typeJson: "{\"primitive\":\"number\"}")]
        double SizeBytes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceLocalDisk), fullyQualifiedName: "yandex.computeInstance.ComputeInstanceLocalDisk")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstance.IComputeInstanceLocalDisk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#size_bytes ComputeInstance#size_bytes}.</summary>
            [JsiiProperty(name: "sizeBytes", typeJson: "{\"primitive\":\"number\"}")]
            public double SizeBytes
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
