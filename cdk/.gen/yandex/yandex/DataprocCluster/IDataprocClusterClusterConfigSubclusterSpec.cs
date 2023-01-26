using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataprocCluster
{
    [JsiiInterface(nativeType: typeof(IDataprocClusterClusterConfigSubclusterSpec), fullyQualifiedName: "yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpec")]
    public interface IDataprocClusterClusterConfigSubclusterSpec
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#hosts_count DataprocCluster#hosts_count}.</summary>
        [JsiiProperty(name: "hostsCount", typeJson: "{\"primitive\":\"number\"}")]
        double HostsCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#name DataprocCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#resources DataprocCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecResources\"}")]
        yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecResources Resources
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#role DataprocCluster#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#subnet_id DataprocCluster#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#assign_public_ip DataprocCluster#assign_public_ip}.</summary>
        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AssignPublicIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>autoscaling_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#autoscaling_config DataprocCluster#autoscaling_config}
        /// </remarks>
        [JsiiProperty(name: "autoscalingConfig", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig? AutoscalingConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataprocClusterClusterConfigSubclusterSpec), fullyQualifiedName: "yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpec")]
        internal sealed class _Proxy : DeputyBase, yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#hosts_count DataprocCluster#hosts_count}.</summary>
            [JsiiProperty(name: "hostsCount", typeJson: "{\"primitive\":\"number\"}")]
            public double HostsCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#name DataprocCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#resources DataprocCluster#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecResources\"}")]
            public yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecResources Resources
            {
                get => GetInstanceProperty<yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecResources>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#role DataprocCluster#role}.</summary>
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#subnet_id DataprocCluster#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#assign_public_ip DataprocCluster#assign_public_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AssignPublicIp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>autoscaling_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#autoscaling_config DataprocCluster#autoscaling_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoscalingConfig", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig\"}", isOptional: true)]
            public yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig? AutoscalingConfig
            {
                get => GetInstanceProperty<yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig?>();
            }
        }
    }
}
