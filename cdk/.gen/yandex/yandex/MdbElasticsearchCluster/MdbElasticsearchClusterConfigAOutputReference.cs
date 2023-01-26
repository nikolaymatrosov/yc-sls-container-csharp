using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbElasticsearchCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigAOutputReference), fullyQualifiedName: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbElasticsearchClusterConfigAOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbElasticsearchClusterConfigAOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbElasticsearchClusterConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbElasticsearchClusterConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNode\"}}]")]
        public virtual void PutDataNode(yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMasterNode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNode\"}}]")]
        public virtual void PutMasterNode(yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEdition")]
        public virtual void ResetEdition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterNode")]
        public virtual void ResetMasterNode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlugins")]
        public virtual void ResetPlugins()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dataNode", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeOutputReference\"}")]
        public virtual yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeOutputReference DataNode
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNodeOutputReference>()!;
        }

        [JsiiProperty(name: "masterNode", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeOutputReference\"}")]
        public virtual yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeOutputReference MasterNode
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNodeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataNodeInput", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigDataNode\"}", isOptional: true)]
        public virtual yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode? DataNodeInput
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigDataNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "editionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EditionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterNodeInput", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigMasterNode\"}", isOptional: true)]
        public virtual yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode? MasterNodeInput
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigMasterNode?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pluginsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PluginsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "edition", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Edition
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "plugins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Plugins
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbElasticsearchCluster.MdbElasticsearchClusterConfigA\"}", isOptional: true)]
        public virtual yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigA? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
