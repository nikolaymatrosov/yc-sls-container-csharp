using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataprocCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataprocCluster.DataprocClusterClusterConfig")]
    public class DataprocClusterClusterConfig : yandex.DataprocCluster.IDataprocClusterClusterConfig
    {
        private object _subclusterSpec;

        /// <summary>subcluster_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#subcluster_spec DataprocCluster#subcluster_spec}
        /// </remarks>
        [JsiiProperty(name: "subclusterSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpec\"},\"kind\":\"array\"}}]}}")]
        public object SubclusterSpec
        {
            get => _subclusterSpec;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpec[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpec).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpec).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _subclusterSpec = value;
            }
        }

        /// <summary>hadoop block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#hadoop DataprocCluster#hadoop}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hadoop", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigHadoop\"}", isOptional: true)]
        public yandex.DataprocCluster.IDataprocClusterClusterConfigHadoop? Hadoop
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#version_id DataprocCluster#version_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VersionId
        {
            get;
            set;
        }
    }
}
