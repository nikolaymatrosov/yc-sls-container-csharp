using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScale")]
    public class ComputeInstanceGroupScalePolicyAutoScale : yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#initial_size ComputeInstanceGroup#initial_size}.</summary>
        [JsiiProperty(name: "initialSize", typeJson: "{\"primitive\":\"number\"}")]
        public double InitialSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#measurement_duration ComputeInstanceGroup#measurement_duration}.</summary>
        [JsiiProperty(name: "measurementDuration", typeJson: "{\"primitive\":\"number\"}")]
        public double MeasurementDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#cpu_utilization_target ComputeInstanceGroup#cpu_utilization_target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuUtilizationTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuUtilizationTarget
        {
            get;
            set;
        }

        private object? _customRule;

        /// <summary>custom_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#custom_rule ComputeInstanceGroup#custom_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyAutoScaleCustomRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomRule
        {
            get => _customRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScaleCustomRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicyAutoScaleCustomRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customRule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_size ComputeInstanceGroup#max_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#min_zone_size ComputeInstanceGroup#min_zone_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minZoneSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinZoneSize
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#stabilization_duration ComputeInstanceGroup#stabilization_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stabilizationDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StabilizationDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#warmup_duration ComputeInstanceGroup#warmup_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warmupDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WarmupDuration
        {
            get;
            set;
        }
    }
}
