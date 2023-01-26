using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbElasticsearchCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbElasticsearchCluster.DataYandexMdbElasticsearchClusterConfigAOutputReference), fullyQualifiedName: "yandex.dataYandexMdbElasticsearchCluster.DataYandexMdbElasticsearchClusterConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexMdbElasticsearchClusterConfigAOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexMdbElasticsearchClusterConfigAOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbElasticsearchClusterConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbElasticsearchClusterConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dataNode", typeJson: "{\"fqn\":\"yandex.dataYandexMdbElasticsearchCluster.DataYandexMdbElasticsearchClusterConfigDataNodeList\"}")]
        public virtual yandex.DataYandexMdbElasticsearchCluster.DataYandexMdbElasticsearchClusterConfigDataNodeList DataNode
        {
            get => GetInstanceProperty<yandex.DataYandexMdbElasticsearchCluster.DataYandexMdbElasticsearchClusterConfigDataNodeList>()!;
        }

        [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Edition
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "masterNode", typeJson: "{\"fqn\":\"yandex.dataYandexMdbElasticsearchCluster.DataYandexMdbElasticsearchClusterConfigMasterNodeList\"}")]
        public virtual yandex.DataYandexMdbElasticsearchCluster.DataYandexMdbElasticsearchClusterConfigMasterNodeList MasterNode
        {
            get => GetInstanceProperty<yandex.DataYandexMdbElasticsearchCluster.DataYandexMdbElasticsearchClusterConfigMasterNodeList>()!;
        }

        [JsiiProperty(name: "plugins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Plugins
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbElasticsearchCluster.DataYandexMdbElasticsearchClusterConfigA\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbElasticsearchCluster.IDataYandexMdbElasticsearchClusterConfigA? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbElasticsearchCluster.IDataYandexMdbElasticsearchClusterConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
