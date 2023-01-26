using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiInterface(nativeType: typeof(IMdbMongodbClusterClusterConfig), fullyQualifiedName: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfig")]
    public interface IMdbMongodbClusterClusterConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#version MdbMongodbCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>access block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#access MdbMongodbCluster#access}
        /// </remarks>
        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigAccess\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigAccess? Access
        {
            get
            {
                return null;
            }
        }

        /// <summary>backup_window_start block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#backup_window_start MdbMongodbCluster#backup_window_start}
        /// </remarks>
        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigBackupWindowStart\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigBackupWindowStart? BackupWindowStart
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#feature_compatibility_version MdbMongodbCluster#feature_compatibility_version}.</summary>
        [JsiiProperty(name: "featureCompatibilityVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FeatureCompatibilityVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>mongod block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#mongod MdbMongodbCluster#mongod}
        /// </remarks>
        [JsiiProperty(name: "mongod", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod? Mongod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbMongodbClusterClusterConfig), fullyQualifiedName: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#version MdbMongodbCluster#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>access block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#access MdbMongodbCluster#access}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigAccess\"}", isOptional: true)]
            public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigAccess? Access
            {
                get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigAccess?>();
            }

            /// <summary>backup_window_start block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#backup_window_start MdbMongodbCluster#backup_window_start}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigBackupWindowStart\"}", isOptional: true)]
            public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigBackupWindowStart? BackupWindowStart
            {
                get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigBackupWindowStart?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#feature_compatibility_version MdbMongodbCluster#feature_compatibility_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "featureCompatibilityVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FeatureCompatibilityVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>mongod block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#mongod MdbMongodbCluster#mongod}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mongod", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongod\"}", isOptional: true)]
            public yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod? Mongod
            {
                get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod?>();
            }
        }
    }
}
