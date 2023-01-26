using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaConnectorConnectorConfigS3SinkS3Connection), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3Connection")]
    public interface IMdbKafkaConnectorConnectorConfigS3SinkS3Connection
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#bucket_name MdbKafkaConnector#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        string BucketName
        {
            get;
        }

        /// <summary>external_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#external_s3 MdbKafkaConnector#external_s3}
        /// </remarks>
        [JsiiProperty(name: "externalS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3ConnectionExternalS3\"},\"kind\":\"array\"}}]}}")]
        object ExternalS3
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaConnectorConnectorConfigS3SinkS3Connection), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3Connection")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3Connection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#bucket_name MdbKafkaConnector#bucket_name}.</summary>
            [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
            public string BucketName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>external_s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#external_s3 MdbKafkaConnector#external_s3}
            /// </remarks>
            [JsiiProperty(name: "externalS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3ConnectionExternalS3\"},\"kind\":\"array\"}}]}}")]
            public object ExternalS3
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
