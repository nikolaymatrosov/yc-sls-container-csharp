using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaConnector
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_connector yandex_mdb_kafka_connector}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbKafkaConnector.DataYandexMdbKafkaConnector), fullyQualifiedName: "yandex.dataYandexMdbKafkaConnector.DataYandexMdbKafkaConnector", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.dataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConfig\"}}]")]
    public class DataYandexMdbKafkaConnector : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_connector yandex_mdb_kafka_connector} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexMdbKafkaConnector(Constructs.Construct scope, string id, yandex.DataYandexMdbKafkaConnector.IDataYandexMdbKafkaConnectorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexMdbKafkaConnector.IDataYandexMdbKafkaConnectorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbKafkaConnector(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbKafkaConnector(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(yandex.DataYandexMdbKafkaConnector.DataYandexMdbKafkaConnector))!;

        [JsiiProperty(name: "connectorConfigMirrormaker", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigMirrormakerList\"}")]
        public virtual yandex.DataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigMirrormakerList ConnectorConfigMirrormaker
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigMirrormakerList>()!;
        }

        [JsiiProperty(name: "connectorConfigS3Sink", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigS3SinkList\"}")]
        public virtual yandex.DataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigS3SinkList ConnectorConfigS3Sink
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigS3SinkList>()!;
        }

        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Properties
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "tasksMax", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TasksMax
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
