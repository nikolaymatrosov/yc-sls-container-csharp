using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiInterface(nativeType: typeof(IMdbMongodbClusterClusterConfigMongodSecurity), fullyQualifiedName: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurity")]
    public interface IMdbMongodbClusterClusterConfigMongodSecurity
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#enable_encryption MdbMongodbCluster#enable_encryption}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#kmip MdbMongodbCluster#kmip}
        /// </remarks>
        [JsiiProperty(name: "kmip", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityKmip\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurityKmip? Kmip
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbMongodbClusterClusterConfigMongodSecurity), fullyQualifiedName: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurity")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#enable_encryption MdbMongodbCluster#enable_encryption}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableEncryption
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>kmip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#kmip MdbMongodbCluster#kmip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kmip", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityKmip\"}", isOptional: true)]
            public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurityKmip? Kmip
            {
                get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurityKmip?>();
            }
        }
    }
}
