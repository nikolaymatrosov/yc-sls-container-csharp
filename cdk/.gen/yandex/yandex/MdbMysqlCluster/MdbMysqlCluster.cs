using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster yandex_mdb_mysql_cluster}.</summary>
    [JsiiClass(nativeType: typeof(yandex.MdbMysqlCluster.MdbMysqlCluster), fullyQualifiedName: "yandex.mdbMysqlCluster.MdbMysqlCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterConfig\"}}]")]
    public class MdbMysqlCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster yandex_mdb_mysql_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MdbMysqlCluster(Constructs.Construct scope, string id, yandex.MdbMysqlCluster.IMdbMysqlClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.MdbMysqlCluster.IMdbMysqlClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbMysqlCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbMysqlCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterAccess\"}}]")]
        public virtual void PutAccess(yandex.MdbMysqlCluster.IMdbMysqlClusterAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackupWindowStart", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterBackupWindowStart\"}}]")]
        public virtual void PutBackupWindowStart(yandex.MdbMysqlCluster.IMdbMysqlClusterBackupWindowStart @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterBackupWindowStart)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterDatabase\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDatabase(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.MdbMysqlCluster.IMdbMysqlClusterDatabase[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterDatabase).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterDatabase).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHost", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterHost\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHost(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.MdbMysqlCluster.IMdbMysqlClusterHost[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterHost).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterHost).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceWindow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterMaintenanceWindow\"}}]")]
        public virtual void PutMaintenanceWindow(yandex.MdbMysqlCluster.IMdbMysqlClusterMaintenanceWindow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterMaintenanceWindow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerformanceDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterPerformanceDiagnostics\"}}]")]
        public virtual void PutPerformanceDiagnostics(yandex.MdbMysqlCluster.IMdbMysqlClusterPerformanceDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterPerformanceDiagnostics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterResources\"}}]")]
        public virtual void PutResources(yandex.MdbMysqlCluster.IMdbMysqlClusterResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRestore", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterRestore\"}}]")]
        public virtual void PutRestore(yandex.MdbMysqlCluster.IMdbMysqlClusterRestore @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterRestore)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.MdbMysqlCluster.IMdbMysqlClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUser\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutUser(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.MdbMysqlCluster.IMdbMysqlClusterUser[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterUser).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterUser).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccess")]
        public virtual void ResetAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowRegenerationHost")]
        public virtual void ResetAllowRegenerationHost()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupRetainPeriodDays")]
        public virtual void ResetBackupRetainPeriodDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupWindowStart")]
        public virtual void ResetBackupWindowStart()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabase")]
        public virtual void ResetDatabase()
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

        [JsiiMethod(name: "resetHostGroupIds")]
        public virtual void ResetHostGroupIds()
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

        [JsiiMethod(name: "resetMaintenanceWindow")]
        public virtual void ResetMaintenanceWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMysqlConfig")]
        public virtual void ResetMysqlConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerformanceDiagnostics")]
        public virtual void ResetPerformanceDiagnostics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRestore")]
        public virtual void ResetRestore()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroupIds")]
        public virtual void ResetSecurityGroupIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUser")]
        public virtual void ResetUser()
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
        = GetStaticProperty<string>(typeof(yandex.MdbMysqlCluster.MdbMysqlCluster))!;

        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterAccessOutputReference\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterAccessOutputReference Access
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterAccessOutputReference>()!;
        }

        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterBackupWindowStartOutputReference\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterBackupWindowStartOutputReference BackupWindowStart
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterBackupWindowStartOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterDatabaseList\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterDatabaseList Database
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterDatabaseList>()!;
        }

        [JsiiProperty(name: "health", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Health
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "host", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterHostList\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterHostList Host
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterHostList>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterMaintenanceWindowOutputReference\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterMaintenanceWindowOutputReference MaintenanceWindow
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterMaintenanceWindowOutputReference>()!;
        }

        [JsiiProperty(name: "performanceDiagnostics", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterPerformanceDiagnosticsOutputReference\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterPerformanceDiagnosticsOutputReference PerformanceDiagnostics
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterPerformanceDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterResourcesOutputReference\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterResourcesOutputReference>()!;
        }

        [JsiiProperty(name: "restore", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterRestoreOutputReference\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterRestoreOutputReference Restore
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterRestoreOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterTimeoutsOutputReference\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserList\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterUserList User
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterUserList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessInput", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterAccess\"}", isOptional: true)]
        public virtual yandex.MdbMysqlCluster.IMdbMysqlClusterAccess? AccessInput
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.IMdbMysqlClusterAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowRegenerationHostInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowRegenerationHostInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupRetainPeriodDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackupRetainPeriodDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupWindowStartInput", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterBackupWindowStart\"}", isOptional: true)]
        public virtual yandex.MdbMysqlCluster.IMdbMysqlClusterBackupWindowStart? BackupWindowStartInput
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.IMdbMysqlClusterBackupWindowStart?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DatabaseInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "environmentInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EnvironmentInput
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
        [JsiiProperty(name: "hostGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? HostGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterHost\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "maintenanceWindowInput", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterMaintenanceWindow\"}", isOptional: true)]
        public virtual yandex.MdbMysqlCluster.IMdbMysqlClusterMaintenanceWindow? MaintenanceWindowInput
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.IMdbMysqlClusterMaintenanceWindow?>();
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

        [JsiiOptional]
        [JsiiProperty(name: "networkIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceDiagnosticsInput", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterPerformanceDiagnostics\"}", isOptional: true)]
        public virtual yandex.MdbMysqlCluster.IMdbMysqlClusterPerformanceDiagnostics? PerformanceDiagnosticsInput
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.IMdbMysqlClusterPerformanceDiagnostics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterResources\"}", isOptional: true)]
        public virtual yandex.MdbMysqlCluster.IMdbMysqlClusterResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.IMdbMysqlClusterResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "restoreInput", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterRestore\"}", isOptional: true)]
        public virtual yandex.MdbMysqlCluster.IMdbMysqlClusterRestore? RestoreInput
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.IMdbMysqlClusterRestore?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUser\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? UserInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "allowRegenerationHost", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AllowRegenerationHost
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

        [JsiiProperty(name: "backupRetainPeriodDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupRetainPeriodDays
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "environment", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Environment
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

        [JsiiProperty(name: "hostGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] HostGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
