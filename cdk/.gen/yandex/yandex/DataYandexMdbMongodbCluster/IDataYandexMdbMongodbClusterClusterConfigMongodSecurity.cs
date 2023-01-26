using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMongodbCluster
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbMongodbClusterClusterConfigMongodSecurity), fullyQualifiedName: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurity")]
    public interface IDataYandexMdbMongodbClusterClusterConfigMongodSecurity
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#enable_encryption DataYandexMdbMongodbCluster#enable_encryption}.</summary>
        [JsiiProperty(name: "enableEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableEncryption
        {
            get
            {
                return null;
            }
        }

        /// <summary>kmip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#kmip DataYandexMdbMongodbCluster#kmip}
        /// </remarks>
        [JsiiProperty(name: "kmip", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip? Kmip
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbMongodbClusterClusterConfigMongodSecurity), fullyQualifiedName: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurity")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#enable_encryption DataYandexMdbMongodbCluster#enable_encryption}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableEncryption
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>kmip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#kmip DataYandexMdbMongodbCluster#kmip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kmip", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip\"}", isOptional: true)]
            public yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip? Kmip
            {
                get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip?>();
            }
        }
    }
}
