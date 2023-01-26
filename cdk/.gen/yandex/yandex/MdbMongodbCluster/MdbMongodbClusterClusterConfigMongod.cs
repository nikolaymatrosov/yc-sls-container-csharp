using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiByValue(fqn: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongod")]
    public class MdbMongodbClusterClusterConfigMongod : yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod
    {
        /// <summary>audit_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#audit_log MdbMongodbCluster#audit_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auditLog", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodAuditLog\"}", isOptional: true)]
        public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodAuditLog? AuditLog
        {
            get;
            set;
        }

        /// <summary>security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#security MdbMongodbCluster#security}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurity\"}", isOptional: true)]
        public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity? Security
        {
            get;
            set;
        }

        /// <summary>set_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#set_parameter MdbMongodbCluster#set_parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setParameter", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSetParameter\"}", isOptional: true)]
        public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSetParameter? SetParameter
        {
            get;
            set;
        }
    }
}
