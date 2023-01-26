using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiByValue(fqn: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSetParameter")]
    public class MdbMongodbClusterClusterConfigMongodSetParameter : yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSetParameter
    {
        private object? _auditAuthorizationSuccess;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#audit_authorization_success MdbMongodbCluster#audit_authorization_success}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "auditAuthorizationSuccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AuditAuthorizationSuccess
        {
            get => _auditAuthorizationSuccess;
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
                _auditAuthorizationSuccess = value;
            }
        }
    }
}
