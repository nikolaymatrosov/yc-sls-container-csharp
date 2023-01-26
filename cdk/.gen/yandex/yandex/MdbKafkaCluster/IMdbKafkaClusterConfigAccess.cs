using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaCluster
{
    [JsiiInterface(nativeType: typeof(IMdbKafkaClusterConfigAccess), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigAccess")]
    public interface IMdbKafkaClusterConfigAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#data_transfer MdbKafkaCluster#data_transfer}.</summary>
        [JsiiProperty(name: "dataTransfer", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataTransfer
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbKafkaClusterConfigAccess), fullyQualifiedName: "yandex.mdbKafkaCluster.MdbKafkaClusterConfigAccess")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbKafkaCluster.IMdbKafkaClusterConfigAccess
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_kafka_cluster#data_transfer MdbKafkaCluster#data_transfer}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataTransfer", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DataTransfer
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
