using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataprocCluster
{
    [JsiiInterface(nativeType: typeof(IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig), fullyQualifiedName: "yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig")]
    public interface IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#max_hosts_count DataprocCluster#max_hosts_count}.</summary>
        [JsiiProperty(name: "maxHostsCount", typeJson: "{\"primitive\":\"number\"}")]
        double MaxHostsCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#cpu_utilization_target DataprocCluster#cpu_utilization_target}.</summary>
        [JsiiProperty(name: "cpuUtilizationTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? CpuUtilizationTarget
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#decommission_timeout DataprocCluster#decommission_timeout}.</summary>
        [JsiiProperty(name: "decommissionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DecommissionTimeout
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#measurement_duration DataprocCluster#measurement_duration}.</summary>
        [JsiiProperty(name: "measurementDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MeasurementDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#preemptible DataprocCluster#preemptible}.</summary>
        [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Preemptible
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#stabilization_duration DataprocCluster#stabilization_duration}.</summary>
        [JsiiProperty(name: "stabilizationDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StabilizationDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#warmup_duration DataprocCluster#warmup_duration}.</summary>
        [JsiiProperty(name: "warmupDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WarmupDuration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig), fullyQualifiedName: "yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#max_hosts_count DataprocCluster#max_hosts_count}.</summary>
            [JsiiProperty(name: "maxHostsCount", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxHostsCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#cpu_utilization_target DataprocCluster#cpu_utilization_target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cpuUtilizationTarget", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? CpuUtilizationTarget
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#decommission_timeout DataprocCluster#decommission_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "decommissionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DecommissionTimeout
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#measurement_duration DataprocCluster#measurement_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "measurementDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MeasurementDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#preemptible DataprocCluster#preemptible}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Preemptible
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#stabilization_duration DataprocCluster#stabilization_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "stabilizationDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StabilizationDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#warmup_duration DataprocCluster#warmup_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "warmupDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WarmupDuration
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
