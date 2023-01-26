using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbElasticsearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNode")]
    public class MdbElasticsearchClusterConfigMasterNode : yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#resources MdbElasticsearchCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeResources\"}")]
        public yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNodeResources Resources
        {
            get;
            set;
        }
    }
}
