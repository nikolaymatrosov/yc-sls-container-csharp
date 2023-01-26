using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaConnectorConnectorConfigS3Sink), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3Sink")]
    public interface IMdbKafkaConnectorConnectorConfigS3Sink
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#file_compression_type MdbKafkaConnector#file_compression_type}.</summary>
        [JsiiProperty(name: "fileCompressionType", typeJson: "{\"primitive\":\"string\"}")]
        string FileCompressionType
        {
            get;
        }

        /// <summary>s3_connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#s3_connection MdbKafkaConnector#s3_connection}
        /// </remarks>
        [JsiiProperty(name: "s3Connection", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3Connection\"}")]
        yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3Connection S3Connection
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#topics MdbKafkaConnector#topics}.</summary>
        [JsiiProperty(name: "topics", typeJson: "{\"primitive\":\"string\"}")]
        string Topics
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#file_max_records MdbKafkaConnector#file_max_records}.</summary>
        [JsiiProperty(name: "fileMaxRecords", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FileMaxRecords
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaConnectorConnectorConfigS3Sink), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3Sink")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3Sink
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#file_compression_type MdbKafkaConnector#file_compression_type}.</summary>
            [JsiiProperty(name: "fileCompressionType", typeJson: "{\"primitive\":\"string\"}")]
            public string FileCompressionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>s3_connection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#s3_connection MdbKafkaConnector#s3_connection}
            /// </remarks>
            [JsiiProperty(name: "s3Connection", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3Connection\"}")]
            public yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3Connection S3Connection
            {
                get => GetInstanceProperty<yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3Connection>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#topics MdbKafkaConnector#topics}.</summary>
            [JsiiProperty(name: "topics", typeJson: "{\"primitive\":\"string\"}")]
            public string Topics
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#file_max_records MdbKafkaConnector#file_max_records}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fileMaxRecords", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FileMaxRecords
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
