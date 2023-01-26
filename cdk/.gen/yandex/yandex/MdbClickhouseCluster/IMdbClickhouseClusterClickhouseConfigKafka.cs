using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterClickhouseConfigKafka), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafka")]
    public interface IMdbClickhouseClusterClickhouseConfigKafka
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#sasl_mechanism MdbClickhouseCluster#sasl_mechanism}.</summary>
        [JsiiProperty(name: "saslMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SaslMechanism
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#sasl_password MdbClickhouseCluster#sasl_password}.</summary>
        [JsiiProperty(name: "saslPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SaslPassword
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#sasl_username MdbClickhouseCluster#sasl_username}.</summary>
        [JsiiProperty(name: "saslUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SaslUsername
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#security_protocol MdbClickhouseCluster#security_protocol}.</summary>
        [JsiiProperty(name: "securityProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecurityProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterClickhouseConfigKafka), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigKafka")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfigKafka
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#sasl_mechanism MdbClickhouseCluster#sasl_mechanism}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saslMechanism", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SaslMechanism
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#sasl_password MdbClickhouseCluster#sasl_password}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saslPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SaslPassword
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#sasl_username MdbClickhouseCluster#sasl_username}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "saslUsername", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SaslUsername
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#security_protocol MdbClickhouseCluster#security_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecurityProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
