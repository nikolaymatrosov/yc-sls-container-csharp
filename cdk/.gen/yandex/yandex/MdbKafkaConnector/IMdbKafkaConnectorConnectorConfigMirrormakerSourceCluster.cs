using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceCluster")]
    public interface IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#alias MdbKafkaConnector#alias}.</summary>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>external_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#external_cluster MdbKafkaConnector#external_cluster}
        /// </remarks>
        [JsiiProperty(name: "externalCluster", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExternalCluster
        {
            get
            {
                return null;
            }
        }

        /// <summary>this_cluster block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#this_cluster MdbKafkaConnector#this_cluster}
        /// </remarks>
        [JsiiProperty(name: "thisCluster", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisCluster\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ThisCluster
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceCluster")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#alias MdbKafkaConnector#alias}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>external_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#external_cluster MdbKafkaConnector#external_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalCluster", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExternalCluster
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>this_cluster block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_connector#this_cluster MdbKafkaConnector#this_cluster}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "thisCluster", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisCluster\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ThisCluster
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
