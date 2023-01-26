using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiInterface(nativeType: typeof(IMdbMongodbClusterClusterConfigMongod), fullyQualifiedName: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongod")]
    public interface IMdbMongodbClusterClusterConfigMongod
    {
        /// <summary>audit_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#audit_log MdbMongodbCluster#audit_log}
        /// </remarks>
        [JsiiProperty(name: "auditLog", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodAuditLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodAuditLog? AuditLog
        {
            get
            {
                return null;
            }
        }

        /// <summary>security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#security MdbMongodbCluster#security}
        /// </remarks>
        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity? Security
        {
            get
            {
                return null;
            }
        }

        /// <summary>set_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#set_parameter MdbMongodbCluster#set_parameter}
        /// </remarks>
        [JsiiProperty(name: "setParameter", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSetParameter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSetParameter? SetParameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbMongodbClusterClusterConfigMongod), fullyQualifiedName: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongod")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>audit_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#audit_log MdbMongodbCluster#audit_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "auditLog", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodAuditLog\"}", isOptional: true)]
            public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodAuditLog? AuditLog
            {
                get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodAuditLog?>();
            }

            /// <summary>security block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#security MdbMongodbCluster#security}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurity\"}", isOptional: true)]
            public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity? Security
            {
                get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity?>();
            }

            /// <summary>set_parameter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#set_parameter MdbMongodbCluster#set_parameter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setParameter", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSetParameter\"}", isOptional: true)]
            public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSetParameter? SetParameter
            {
                get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSetParameter?>();
            }
        }
    }
}
