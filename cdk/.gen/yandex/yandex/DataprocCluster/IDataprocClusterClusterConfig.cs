using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataprocCluster
{
    [JsiiInterface(nativeType: typeof(IDataprocClusterClusterConfig), fullyQualifiedName: "yandex.dataprocCluster.DataprocClusterClusterConfig")]
    public interface IDataprocClusterClusterConfig
    {
        /// <summary>subcluster_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#subcluster_spec DataprocCluster#subcluster_spec}
        /// </remarks>
        [JsiiProperty(name: "subclusterSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpec\"},\"kind\":\"array\"}}]}}")]
        object SubclusterSpec
        {
            get;
        }

        /// <summary>hadoop block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#hadoop DataprocCluster#hadoop}
        /// </remarks>
        [JsiiProperty(name: "hadoop", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigHadoop\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataprocCluster.IDataprocClusterClusterConfigHadoop? Hadoop
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#version_id DataprocCluster#version_id}.</summary>
        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VersionId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataprocClusterClusterConfig), fullyQualifiedName: "yandex.dataprocCluster.DataprocClusterClusterConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.DataprocCluster.IDataprocClusterClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>subcluster_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#subcluster_spec DataprocCluster#subcluster_spec}
            /// </remarks>
            [JsiiProperty(name: "subclusterSpec", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpec\"},\"kind\":\"array\"}}]}}")]
            public object SubclusterSpec
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>hadoop block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#hadoop DataprocCluster#hadoop}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hadoop", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigHadoop\"}", isOptional: true)]
            public yandex.DataprocCluster.IDataprocClusterClusterConfigHadoop? Hadoop
            {
                get => GetInstanceProperty<yandex.DataprocCluster.IDataprocClusterClusterConfigHadoop?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/dataproc_cluster#version_id DataprocCluster#version_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VersionId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
