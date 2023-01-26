using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaConnector
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalClusterOutputReference), fullyQualifiedName: "yandex.dataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalClusterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalClusterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalClusterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalClusterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalClusterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "bootstrapServers", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BootstrapServers
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "saslMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SaslMechanism
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "saslPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SaslPassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "saslUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SaslUsername
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalCluster\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbKafkaConnector.IDataYandexMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalCluster? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaConnector.IDataYandexMdbKafkaConnectorConnectorConfigMirrormakerTargetClusterExternalCluster?>();
            set => SetInstanceProperty(value);
        }
    }
}
