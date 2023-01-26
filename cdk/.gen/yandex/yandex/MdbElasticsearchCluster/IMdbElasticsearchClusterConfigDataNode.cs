using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbElasticsearchCluster
{
    [JsiiInterface(nativeType: typeof(IMdbElasticsearchClusterConfigDataNode), fullyQualifiedName: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNode")]
    public interface IMdbElasticsearchClusterConfigDataNode
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#resources MdbElasticsearchCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeResources\"}")]
        yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNodeResources Resources
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbElasticsearchClusterConfigDataNode), fullyQualifiedName: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNode")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#resources MdbElasticsearchCluster#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeResources\"}")]
            public yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNodeResources Resources
            {
                get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNodeResources>()!;
            }
        }
    }
}
