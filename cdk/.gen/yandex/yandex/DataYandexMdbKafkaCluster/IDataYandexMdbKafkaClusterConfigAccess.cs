using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbKafkaClusterConfigAccess), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigAccess")]
    public interface IDataYandexMdbKafkaClusterConfigAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#data_transfer DataYandexMdbKafkaCluster#data_transfer}.</summary>
        [JsiiProperty(name: "dataTransfer", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataTransfer
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbKafkaClusterConfigAccess), fullyQualifiedName: "yandex.dataYandexMdbKafkaCluster.DataYandexMdbKafkaClusterConfigAccess")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbKafkaCluster.IDataYandexMdbKafkaClusterConfigAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_kafka_cluster#data_transfer DataYandexMdbKafkaCluster#data_transfer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataTransfer", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DataTransfer
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
