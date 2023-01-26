using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaConnector
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigS3SinkOutputReference), fullyQualifiedName: "yandex.dataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigS3SinkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexMdbKafkaConnectorConnectorConfigS3SinkOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexMdbKafkaConnectorConnectorConfigS3SinkOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexMdbKafkaConnectorConnectorConfigS3SinkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbKafkaConnectorConnectorConfigS3SinkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "fileCompressionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileCompressionType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "fileMaxRecords", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FileMaxRecords
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "s3Connection", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigS3SinkS3ConnectionList\"}")]
        public virtual yandex.DataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigS3SinkS3ConnectionList S3Connection
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigS3SinkS3ConnectionList>()!;
        }

        [JsiiProperty(name: "topics", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Topics
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbKafkaConnector.DataYandexMdbKafkaConnectorConnectorConfigS3Sink\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbKafkaConnector.IDataYandexMdbKafkaConnectorConnectorConfigS3Sink? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbKafkaConnector.IDataYandexMdbKafkaConnectorConnectorConfigS3Sink?>();
            set => SetInstanceProperty(value);
        }
    }
}
