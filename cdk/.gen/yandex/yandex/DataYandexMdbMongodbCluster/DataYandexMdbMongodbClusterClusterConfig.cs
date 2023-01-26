using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMongodbCluster
{
    [JsiiByValue(fqn: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfig")]
    public class DataYandexMdbMongodbClusterClusterConfig : yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfig
    {
        /// <summary>access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#access DataYandexMdbMongodbCluster#access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigAccess\"}", isOptional: true)]
        public yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigAccess? Access
        {
            get;
            set;
        }

        /// <summary>backup_window_start block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#backup_window_start DataYandexMdbMongodbCluster#backup_window_start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigBackupWindowStart\"}", isOptional: true)]
        public yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigBackupWindowStart? BackupWindowStart
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#feature_compatibility_version DataYandexMdbMongodbCluster#feature_compatibility_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "featureCompatibilityVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FeatureCompatibilityVersion
        {
            get;
            set;
        }

        /// <summary>mongod block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#mongod DataYandexMdbMongodbCluster#mongod}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mongod", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongod\"}", isOptional: true)]
        public yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongod? Mongod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#version DataYandexMdbMongodbCluster#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
