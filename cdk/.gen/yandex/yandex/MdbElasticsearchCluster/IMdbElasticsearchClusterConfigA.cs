using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbElasticsearchCluster
{
    [JsiiInterface(nativeType: typeof(IMdbElasticsearchClusterConfigA), fullyQualifiedName: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigA")]
    public interface IMdbElasticsearchClusterConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#admin_password MdbElasticsearchCluster#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        string AdminPassword
        {
            get;
        }

        /// <summary>data_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#data_node MdbElasticsearchCluster#data_node}
        /// </remarks>
        [JsiiProperty(name: "dataNode", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNode\"}")]
        yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode DataNode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#edition MdbElasticsearchCluster#edition}.</summary>
        [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Edition
        {
            get
            {
                return null;
            }
        }

        /// <summary>master_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#master_node MdbElasticsearchCluster#master_node}
        /// </remarks>
        [JsiiProperty(name: "masterNode", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNode\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode? MasterNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#plugins MdbElasticsearchCluster#plugins}.</summary>
        [JsiiProperty(name: "plugins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Plugins
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#version MdbElasticsearchCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbElasticsearchClusterConfigA), fullyQualifiedName: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigA")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#admin_password MdbElasticsearchCluster#admin_password}.</summary>
            [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
            public string AdminPassword
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>data_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#data_node MdbElasticsearchCluster#data_node}
            /// </remarks>
            [JsiiProperty(name: "dataNode", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNode\"}")]
            public yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode DataNode
            {
                get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#edition MdbElasticsearchCluster#edition}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Edition
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>master_node block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#master_node MdbElasticsearchCluster#master_node}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "masterNode", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNode\"}", isOptional: true)]
            public yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode? MasterNode
            {
                get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#plugins MdbElasticsearchCluster#plugins}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "plugins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Plugins
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#version MdbElasticsearchCluster#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
