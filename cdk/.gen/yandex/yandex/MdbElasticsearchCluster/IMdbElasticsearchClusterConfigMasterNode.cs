using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbElasticsearchCluster
{
    [JsiiInterface(nativeType: typeof(IMdbElasticsearchClusterConfigMasterNode), fullyQualifiedName: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNode")]
    public interface IMdbElasticsearchClusterConfigMasterNode
    {
        /// <summary>resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#resources MdbElasticsearchCluster#resources}
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeResources\"}")]
        yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNodeResources Resources
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbElasticsearchClusterConfigMasterNode), fullyQualifiedName: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNode")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#resources MdbElasticsearchCluster#resources}
            /// </remarks>
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeResources\"}")]
            public yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNodeResources Resources
            {
                get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNodeResources>()!;
            }
        }
    }
}
