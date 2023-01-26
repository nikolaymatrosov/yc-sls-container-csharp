using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    [JsiiInterface(nativeType: typeof(IMdbMysqlClusterUser), fullyQualifiedName: "yandex.mdbMysqlCluster.MdbMysqlClusterUser")]
    public interface IMdbMysqlClusterUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#name MdbMysqlCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#password MdbMysqlCluster#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#authentication_plugin MdbMysqlCluster#authentication_plugin}.</summary>
        [JsiiProperty(name: "authenticationPlugin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthenticationPlugin
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection_limits block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#connection_limits MdbMysqlCluster#connection_limits}
        /// </remarks>
        [JsiiProperty(name: "connectionLimits", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimits\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits? ConnectionLimits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#global_permissions MdbMysqlCluster#global_permissions}.</summary>
        [JsiiProperty(name: "globalPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GlobalPermissions
        {
            get
            {
                return null;
            }
        }

        /// <summary>permission block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#permission MdbMysqlCluster#permission}
        /// </remarks>
        [JsiiProperty(name: "permission", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserPermission\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Permission
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbMysqlClusterUser), fullyQualifiedName: "yandex.mdbMysqlCluster.MdbMysqlClusterUser")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbMysqlCluster.IMdbMysqlClusterUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#name MdbMysqlCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#password MdbMysqlCluster#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#authentication_plugin MdbMysqlCluster#authentication_plugin}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationPlugin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthenticationPlugin
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>connection_limits block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#connection_limits MdbMysqlCluster#connection_limits}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionLimits", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimits\"}", isOptional: true)]
            public yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits? ConnectionLimits
            {
                get => GetInstanceProperty<yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#global_permissions MdbMysqlCluster#global_permissions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "globalPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GlobalPermissions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>permission block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#permission MdbMysqlCluster#permission}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "permission", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserPermission\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Permission
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
