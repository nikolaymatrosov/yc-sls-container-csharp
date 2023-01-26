using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMongodbCluster
{
    [JsiiByValue(fqn: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongod")]
    public class DataYandexMdbMongodbClusterClusterConfigMongod : yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongod
    {
        /// <summary>audit_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#audit_log DataYandexMdbMongodbCluster#audit_log}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auditLog", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodAuditLog\"}", isOptional: true)]
        public yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodAuditLog? AuditLog
        {
            get;
            set;
        }

        /// <summary>security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#security DataYandexMdbMongodbCluster#security}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurity\"}", isOptional: true)]
        public yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurity? Security
        {
            get;
            set;
        }

        /// <summary>set_parameter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#set_parameter DataYandexMdbMongodbCluster#set_parameter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "setParameter", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSetParameter\"}", isOptional: true)]
        public yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSetParameter? SetParameter
        {
            get;
            set;
        }
    }
}
