using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataprocCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig")]
    public class DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig : yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#max_hosts_count DataprocCluster#max_hosts_count}.</summary>
        [JsiiProperty(name: "maxHostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxHostsCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#cpu_utilization_target DataprocCluster#cpu_utilization_target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuUtilizationTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? CpuUtilizationTarget
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#decommission_timeout DataprocCluster#decommission_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "decommissionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DecommissionTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#measurement_duration DataprocCluster#measurement_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "measurementDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MeasurementDuration
        {
            get;
            set;
        }

        private object? _preemptible;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#preemptible DataprocCluster#preemptible}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Preemptible
        {
            get => _preemptible;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _preemptible = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#stabilization_duration DataprocCluster#stabilization_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "stabilizationDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StabilizationDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#warmup_duration DataprocCluster#warmup_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "warmupDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WarmupDuration
        {
            get;
            set;
        }
    }
}
