using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiByValue(fqn: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurity")]
    public class MdbMongodbClusterClusterConfigMongodSecurity : yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity
    {
        private object? _enableEncryption;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#enable_encryption MdbMongodbCluster#enable_encryption}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableEncryption
        {
            get => _enableEncryption;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableEncryption = value;
            }
        }

        /// <summary>kmip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#kmip MdbMongodbCluster#kmip}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kmip", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityKmip\"}", isOptional: true)]
        public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurityKmip? Kmip
        {
            get;
            set;
        }
    }
}
