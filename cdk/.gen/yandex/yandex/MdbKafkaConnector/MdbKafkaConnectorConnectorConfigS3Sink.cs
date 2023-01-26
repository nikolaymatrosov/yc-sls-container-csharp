using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3Sink")]
    public class MdbKafkaConnectorConnectorConfigS3Sink : yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3Sink
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#file_compression_type MdbKafkaConnector#file_compression_type}.</summary>
        [JsiiProperty(name: "fileCompressionType", typeJson: "{\"primitive\":\"string\"}")]
        public string FileCompressionType
        {
            get;
            set;
        }

        /// <summary>s3_connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#s3_connection MdbKafkaConnector#s3_connection}
        /// </remarks>
        [JsiiProperty(name: "s3Connection", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3Connection\"}")]
        public yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3Connection S3Connection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#topics MdbKafkaConnector#topics}.</summary>
        [JsiiProperty(name: "topics", typeJson: "{\"primitive\":\"string\"}")]
        public string Topics
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#file_max_records MdbKafkaConnector#file_max_records}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileMaxRecords", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FileMaxRecords
        {
            get;
            set;
        }
    }
}
