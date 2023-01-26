using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceGroupScalePolicyAutoScale), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScale")]
    public interface IComputeInstanceGroupScalePolicyAutoScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#initial_size ComputeInstanceGroup#initial_size}.</summary>
        [JsiiProperty(name: "initialSize", typeJson: "{\"primitive\":\"number\"}")]
        double InitialSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#measurement_duration ComputeInstanceGroup#measurement_duration}.</summary>
        [JsiiProperty(name: "measurementDuration", typeJson: "{\"primitive\":\"number\"}")]
        double MeasurementDuration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#cpu_utilization_target ComputeInstanceGroup#cpu_utilization_target}.</summary>
        [JsiiProperty(name: "cpuUtilizationTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuUtilizationTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#custom_rule ComputeInstanceGroup#custom_rule}
        /// </remarks>
        [JsiiProperty(name: "customRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScaleCustomRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomRule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_size ComputeInstanceGroup#max_size}.</summary>
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#min_zone_size ComputeInstanceGroup#min_zone_size}.</summary>
        [JsiiProperty(name: "minZoneSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinZoneSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#stabilization_duration ComputeInstanceGroup#stabilization_duration}.</summary>
        [JsiiProperty(name: "stabilizationDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StabilizationDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#warmup_duration ComputeInstanceGroup#warmup_duration}.</summary>
        [JsiiProperty(name: "warmupDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WarmupDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceGroupScalePolicyAutoScale), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScale")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#initial_size ComputeInstanceGroup#initial_size}.</summary>
            [JsiiProperty(name: "initialSize", typeJson: "{\"primitive\":\"number\"}")]
            public double InitialSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#measurement_duration ComputeInstanceGroup#measurement_duration}.</summary>
            [JsiiProperty(name: "measurementDuration", typeJson: "{\"primitive\":\"number\"}")]
            public double MeasurementDuration
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#cpu_utilization_target ComputeInstanceGroup#cpu_utilization_target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuUtilizationTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuUtilizationTarget
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>custom_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#custom_rule ComputeInstanceGroup#custom_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScaleCustomRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomRule
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_size ComputeInstanceGroup#max_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#min_zone_size ComputeInstanceGroup#min_zone_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minZoneSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinZoneSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#stabilization_duration ComputeInstanceGroup#stabilization_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stabilizationDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StabilizationDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#warmup_duration ComputeInstanceGroup#warmup_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warmupDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WarmupDuration
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
