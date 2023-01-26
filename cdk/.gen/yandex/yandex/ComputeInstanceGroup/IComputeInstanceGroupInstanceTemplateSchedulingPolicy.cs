using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceGroupInstanceTemplateSchedulingPolicy), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateSchedulingPolicy")]
    public interface IComputeInstanceGroupInstanceTemplateSchedulingPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#preemptible ComputeInstanceGroup#preemptible}.</summary>
        [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Preemptible
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceGroupInstanceTemplateSchedulingPolicy), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateSchedulingPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateSchedulingPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#preemptible ComputeInstanceGroup#preemptible}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Preemptible
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
