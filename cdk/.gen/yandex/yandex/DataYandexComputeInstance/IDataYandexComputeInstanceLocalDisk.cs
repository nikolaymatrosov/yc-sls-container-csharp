using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstance
{
    [JsiiInterface(nativeType: typeof(IDataYandexComputeInstanceLocalDisk), fullyQualifiedName: "yandex.dataYandexComputeInstance.DataYandexComputeInstanceLocalDisk")]
    public interface IDataYandexComputeInstanceLocalDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#size_bytes DataYandexComputeInstance#size_bytes}.</summary>
        [JsiiProperty(name: "sizeBytes", typeJson: "{\"primitive\":\"number\"}")]
        double SizeBytes
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexComputeInstanceLocalDisk), fullyQualifiedName: "yandex.dataYandexComputeInstance.DataYandexComputeInstanceLocalDisk")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexComputeInstance.IDataYandexComputeInstanceLocalDisk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#size_bytes DataYandexComputeInstance#size_bytes}.</summary>
            [JsiiProperty(name: "sizeBytes", typeJson: "{\"primitive\":\"number\"}")]
            public double SizeBytes
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
