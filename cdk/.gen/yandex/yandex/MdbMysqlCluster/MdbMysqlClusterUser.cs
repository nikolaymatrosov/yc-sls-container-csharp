using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbMysqlCluster.MdbMysqlClusterUser")]
    public class MdbMysqlClusterUser : yandex.MdbMysqlCluster.IMdbMysqlClusterUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#name MdbMysqlCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#password MdbMysqlCluster#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#authentication_plugin MdbMysqlCluster#authentication_plugin}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationPlugin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationPlugin
        {
            get;
            set;
        }

        /// <summary>connection_limits block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#connection_limits MdbMysqlCluster#connection_limits}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionLimits", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimits\"}", isOptional: true)]
        public yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits? ConnectionLimits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#global_permissions MdbMysqlCluster#global_permissions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "globalPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GlobalPermissions
        {
            get;
            set;
        }

        private object? _permission;

        /// <summary>permission block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#permission MdbMysqlCluster#permission}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permission", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserPermission\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Permission
        {
            get => _permission;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.MdbMysqlCluster.IMdbMysqlClusterUserPermission[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterUserPermission).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _permission = value;
            }
        }
    }
}
