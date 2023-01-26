using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfig")]
    public class MdbMongodbClusterClusterConfig : yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#version MdbMongodbCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#access MdbMongodbCluster#access}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigAccess\"}", isOptional: true)]
        public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigAccess? Access
        {
            get;
            set;
        }

        /// <summary>backup_window_start block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#backup_window_start MdbMongodbCluster#backup_window_start}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigBackupWindowStart\"}", isOptional: true)]
        public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigBackupWindowStart? BackupWindowStart
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#feature_compatibility_version MdbMongodbCluster#feature_compatibility_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "featureCompatibilityVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FeatureCompatibilityVersion
        {
            get;
            set;
        }

        /// <summary>mongod block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#mongod MdbMongodbCluster#mongod}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mongod", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongod\"}", isOptional: true)]
        public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod? Mongod
        {
            get;
            set;
        }
    }
}
