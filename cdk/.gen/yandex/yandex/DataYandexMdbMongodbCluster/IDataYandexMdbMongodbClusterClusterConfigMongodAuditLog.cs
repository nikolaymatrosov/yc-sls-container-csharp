using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMongodbCluster
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbMongodbClusterClusterConfigMongodAuditLog), fullyQualifiedName: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodAuditLog")]
    public interface IDataYandexMdbMongodbClusterClusterConfigMongodAuditLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#filter DataYandexMdbMongodbCluster#filter}.</summary>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#runtime_configuration DataYandexMdbMongodbCluster#runtime_configuration}.</summary>
        [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RuntimeConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbMongodbClusterClusterConfigMongodAuditLog), fullyQualifiedName: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodAuditLog")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodAuditLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#filter DataYandexMdbMongodbCluster#filter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#runtime_configuration DataYandexMdbMongodbCluster#runtime_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runtimeConfiguration", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? RuntimeConfiguration
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
