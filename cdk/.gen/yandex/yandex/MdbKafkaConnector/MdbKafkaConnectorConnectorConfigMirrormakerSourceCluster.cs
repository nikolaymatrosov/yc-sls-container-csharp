using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    [JsiiByValue(fqn: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceCluster")]
    public class MdbKafkaConnectorConnectorConfigMirrormakerSourceCluster : yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#alias MdbKafkaConnector#alias}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        private object? _externalCluster;

        /// <summary>external_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#external_cluster MdbKafkaConnector#external_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalCluster", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExternalCluster
        {
            get => _externalCluster;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _externalCluster = value;
            }
        }

        private object? _thisCluster;

        /// <summary>this_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#this_cluster MdbKafkaConnector#this_cluster}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "thisCluster", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisCluster\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ThisCluster
        {
            get => _thisCluster;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisCluster[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisCluster).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _thisCluster = value;
            }
        }
    }
}
