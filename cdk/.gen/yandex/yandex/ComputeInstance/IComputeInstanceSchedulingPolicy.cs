using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceSchedulingPolicy), fullyQualifiedName: "yandex.computeInstance.ComputeInstanceSchedulingPolicy")]
    public interface IComputeInstanceSchedulingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#preemptible ComputeInstance#preemptible}.</summary>
        [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Preemptible
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceSchedulingPolicy), fullyQualifiedName: "yandex.computeInstance.ComputeInstanceSchedulingPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstance.IComputeInstanceSchedulingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#preemptible ComputeInstance#preemptible}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Preemptible
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
