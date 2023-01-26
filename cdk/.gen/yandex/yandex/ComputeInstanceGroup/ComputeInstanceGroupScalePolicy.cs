using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiByValue(fqn: "yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicy")]
    public class ComputeInstanceGroupScalePolicy : yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicy
    {
        /// <summary>auto_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#auto_scale ComputeInstanceGroup#auto_scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScale\"}", isOptional: true)]
        public yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScale? AutoScale
        {
            get;
            set;
        }

        /// <summary>fixed_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#fixed_scale ComputeInstanceGroup#fixed_scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyFixedScale\"}", isOptional: true)]
        public yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyFixedScale? FixedScale
        {
            get;
            set;
        }

        /// <summary>test_auto_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#test_auto_scale ComputeInstanceGroup#test_auto_scale}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "testAutoScale", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyTestAutoScale\"}", isOptional: true)]
        public yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyTestAutoScale? TestAutoScale
        {
            get;
            set;
        }
    }
}
