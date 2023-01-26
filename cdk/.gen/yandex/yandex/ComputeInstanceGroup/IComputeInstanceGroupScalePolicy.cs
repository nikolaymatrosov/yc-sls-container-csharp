using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceGroupScalePolicy), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicy")]
    public interface IComputeInstanceGroupScalePolicy
    {
        /// <summary>auto_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#auto_scale ComputeInstanceGroup#auto_scale}
        /// </remarks>
        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScale\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScale? AutoScale
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#fixed_scale ComputeInstanceGroup#fixed_scale}
        /// </remarks>
        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyFixedScale\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyFixedScale? FixedScale
        {
            get
            {
                return null;
            }
        }

        /// <summary>test_auto_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#test_auto_scale ComputeInstanceGroup#test_auto_scale}
        /// </remarks>
        [JsiiProperty(name: "testAutoScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScale\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScale? TestAutoScale
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceGroupScalePolicy), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>auto_scale block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#auto_scale ComputeInstanceGroup#auto_scale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScale\"}", isOptional: true)]
            public yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScale? AutoScale
            {
                get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScale?>();
            }

            /// <summary>fixed_scale block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#fixed_scale ComputeInstanceGroup#fixed_scale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyFixedScale\"}", isOptional: true)]
            public yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyFixedScale? FixedScale
            {
                get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyFixedScale?>();
            }

            /// <summary>test_auto_scale block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#test_auto_scale ComputeInstanceGroup#test_auto_scale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "testAutoScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScale\"}", isOptional: true)]
            public yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScale? TestAutoScale
            {
                get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScale?>();
            }
        }
    }
}
