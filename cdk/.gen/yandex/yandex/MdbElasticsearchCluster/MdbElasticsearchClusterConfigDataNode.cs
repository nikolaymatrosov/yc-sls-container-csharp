using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbElasticsearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNode")]
    public class MdbElasticsearchClusterConfigDataNode : yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#resources MdbElasticsearchCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeResources\"}")]
        public yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNodeResources Resources
        {
            get;
            set;
        }
    }
}
