using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3Connection")]
    public class MdbKafkaConnectorConnectorConfigS3SinkS3Connection : yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3Connection
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#bucket_name MdbKafkaConnector#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }

        private object _externalS3;

        /// <summary>external_s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#external_s3 MdbKafkaConnector#external_s3}
        /// </remarks>
        [JsiiProperty(name: "externalS3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigS3SinkS3ConnectionExternalS3\"},\"kind\":\"array\"}}]}}")]
        public object ExternalS3
        {
            get => _externalS3;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3ConnectionExternalS3[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3ConnectionExternalS3).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigS3SinkS3ConnectionExternalS3).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _externalS3 = value;
            }
        }
    }
}
