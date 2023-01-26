using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbElasticsearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigA")]
    public class MdbElasticsearchClusterConfigA : yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#admin_password MdbElasticsearchCluster#admin_password}.</summary>
        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public string AdminPassword
        {
            get;
            set;
        }

        /// <summary>data_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#data_node MdbElasticsearchCluster#data_node}
        /// </remarks>
        [JsiiProperty(name: "dataNode", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNode\"}")]
        public yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode DataNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#edition MdbElasticsearchCluster#edition}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Edition
        {
            get;
            set;
        }

        /// <summary>master_node block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#master_node MdbElasticsearchCluster#master_node}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "masterNode", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNode\"}", isOptional: true)]
        public yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode? MasterNode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#plugins MdbElasticsearchCluster#plugins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "plugins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Plugins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#version MdbElasticsearchCluster#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
