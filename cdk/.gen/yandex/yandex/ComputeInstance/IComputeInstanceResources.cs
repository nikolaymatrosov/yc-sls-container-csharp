using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceResources), fullyQualifiedName: "yandex.computeInstance.ComputeInstanceResources")]
    public interface IComputeInstanceResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#cores ComputeInstance#cores}.</summary>
        [JsiiProperty(name: "cores", typeJson: "{\"primitive\":\"number\"}")]
        double Cores
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#memory ComputeInstance#memory}.</summary>
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        double Memory
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#core_fraction ComputeInstance#core_fraction}.</summary>
        [JsiiProperty(name: "coreFraction", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CoreFraction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#gpus ComputeInstance#gpus}.</summary>
        [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Gpus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceResources), fullyQualifiedName: "yandex.computeInstance.ComputeInstanceResources")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstance.IComputeInstanceResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#cores ComputeInstance#cores}.</summary>
            [JsiiProperty(name: "cores", typeJson: "{\"primitive\":\"number\"}")]
            public double Cores
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#memory ComputeInstance#memory}.</summary>
            [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
            public double Memory
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#core_fraction ComputeInstance#core_fraction}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "coreFraction", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CoreFraction
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#gpus ComputeInstance#gpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Gpus
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
