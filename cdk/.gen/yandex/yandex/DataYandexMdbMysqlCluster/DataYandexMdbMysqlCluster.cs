using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMysqlCluster
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mysql_cluster yandex_mdb_mysql_cluster}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlCluster), fullyQualifiedName: "yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterConfig\"}}]")]
    public class DataYandexMdbMysqlCluster : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mysql_cluster yandex_mdb_mysql_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexMdbMysqlCluster(Constructs.Construct scope, string id, yandex.DataYandexMdbMysqlCluster.IDataYandexMdbMysqlClusterConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexMdbMysqlCluster.IDataYandexMdbMysqlClusterConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbMysqlCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbMysqlCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterAccess\"}}]")]
        public virtual void PutAccess(yandex.DataYandexMdbMysqlCluster.IDataYandexMdbMysqlClusterAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexMdbMysqlCluster.IDataYandexMdbMysqlClusterAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccess")]
        public virtual void ResetAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClusterId")]
        public virtual void ResetClusterId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeletionProtection")]
        public virtual void ResetDeletionProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFolderId")]
        public virtual void ResetFolderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMysqlConfig")]
        public virtual void ResetMysqlConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlCluster))!;

        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterAccessOutputReference\"}")]
        public virtual yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterAccessOutputReference Access
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterAccessOutputReference>()!;
        }

        [JsiiProperty(name: "backupRetainPeriodDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupRetainPeriodDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterBackupWindowStartList\"}")]
        public virtual yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterBackupWindowStartList BackupWindowStart
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterBackupWindowStartList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterDatabaseList\"}")]
        public virtual yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterDatabaseList Database
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterDatabaseList>()!;
        }

        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Environment
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "health", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Health
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterHostList\"}")]
        public virtual yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterHostList Host
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterHostList>()!;
        }

        [JsiiProperty(name: "hostGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HostGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterMaintenanceWindowList\"}")]
        public virtual yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "performanceDiagnostics", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterPerformanceDiagnosticsList\"}")]
        public virtual yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterPerformanceDiagnosticsList PerformanceDiagnostics
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterPerformanceDiagnosticsList>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterResourcesList\"}")]
        public virtual yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterResourcesList Resources
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterResourcesList>()!;
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserList\"}")]
        public virtual yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserList User
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessInput", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterAccess\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbMysqlCluster.IDataYandexMdbMysqlClusterAccess? AccessInput
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.IDataYandexMdbMysqlClusterAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deletionProtectionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeletionProtectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "folderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FolderIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mysqlConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MysqlConfigInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deletionProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DeletionProtection
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FolderId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mysqlConfig", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> MysqlConfig
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
