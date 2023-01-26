using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbGreenplumCluster
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster yandex_mdb_greenplum_cluster}.</summary>
    [JsiiClass(nativeType: typeof(yandex.MdbGreenplumCluster.MdbGreenplumCluster), fullyQualifiedName: "yandex.mdbGreenplumCluster.MdbGreenplumCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterConfig\"}}]")]
    public class MdbGreenplumCluster : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/mdb_greenplum_cluster yandex_mdb_greenplum_cluster} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MdbGreenplumCluster(Constructs.Construct scope, string id, yandex.MdbGreenplumCluster.IMdbGreenplumClusterConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.MdbGreenplumCluster.IMdbGreenplumClusterConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbGreenplumCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbGreenplumCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterAccess\"}}]")]
        public virtual void PutAccess(yandex.MdbGreenplumCluster.IMdbGreenplumClusterAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbGreenplumCluster.IMdbGreenplumClusterAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackupWindowStart", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterBackupWindowStart\"}}]")]
        public virtual void PutBackupWindowStart(yandex.MdbGreenplumCluster.IMdbGreenplumClusterBackupWindowStart @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbGreenplumCluster.IMdbGreenplumClusterBackupWindowStart)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceWindow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterMaintenanceWindow\"}}]")]
        public virtual void PutMaintenanceWindow(yandex.MdbGreenplumCluster.IMdbGreenplumClusterMaintenanceWindow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbGreenplumCluster.IMdbGreenplumClusterMaintenanceWindow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMasterSubcluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterMasterSubcluster\"}}]")]
        public virtual void PutMasterSubcluster(yandex.MdbGreenplumCluster.IMdbGreenplumClusterMasterSubcluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbGreenplumCluster.IMdbGreenplumClusterMasterSubcluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPoolerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterPoolerConfig\"}}]")]
        public virtual void PutPoolerConfig(yandex.MdbGreenplumCluster.IMdbGreenplumClusterPoolerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbGreenplumCluster.IMdbGreenplumClusterPoolerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSegmentSubcluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubcluster\"}}]")]
        public virtual void PutSegmentSubcluster(yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubcluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubcluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.MdbGreenplumCluster.IMdbGreenplumClusterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbGreenplumCluster.IMdbGreenplumClusterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccess")]
        public virtual void ResetAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupWindowStart")]
        public virtual void ResetBackupWindowStart()
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

        [JsiiMethod(name: "resetGreenplumConfig")]
        public virtual void ResetGreenplumConfig()
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

        [JsiiMethod(name: "resetPoolerConfig")]
        public virtual void ResetPoolerConfig()
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
        = GetStaticProperty<string>(typeof(yandex.MdbGreenplumCluster.MdbGreenplumCluster))!;

        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterAccessOutputReference\"}")]
        public virtual yandex.MdbGreenplumCluster.MdbGreenplumClusterAccessOutputReference Access
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.MdbGreenplumClusterAccessOutputReference>()!;
        }

        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterBackupWindowStartOutputReference\"}")]
        public virtual yandex.MdbGreenplumCluster.MdbGreenplumClusterBackupWindowStartOutputReference BackupWindowStart
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.MdbGreenplumClusterBackupWindowStartOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "health", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Health
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterMaintenanceWindowOutputReference\"}")]
        public virtual yandex.MdbGreenplumCluster.MdbGreenplumClusterMaintenanceWindowOutputReference MaintenanceWindow
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.MdbGreenplumClusterMaintenanceWindowOutputReference>()!;
        }

        [JsiiProperty(name: "masterHosts", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterMasterHostsList\"}")]
        public virtual yandex.MdbGreenplumCluster.MdbGreenplumClusterMasterHostsList MasterHosts
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.MdbGreenplumClusterMasterHostsList>()!;
        }

        [JsiiProperty(name: "masterSubcluster", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterMasterSubclusterOutputReference\"}")]
        public virtual yandex.MdbGreenplumCluster.MdbGreenplumClusterMasterSubclusterOutputReference MasterSubcluster
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.MdbGreenplumClusterMasterSubclusterOutputReference>()!;
        }

        [JsiiProperty(name: "poolerConfig", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterPoolerConfigOutputReference\"}")]
        public virtual yandex.MdbGreenplumCluster.MdbGreenplumClusterPoolerConfigOutputReference PoolerConfig
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.MdbGreenplumClusterPoolerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "segmentHosts", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentHostsList\"}")]
        public virtual yandex.MdbGreenplumCluster.MdbGreenplumClusterSegmentHostsList SegmentHosts
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.MdbGreenplumClusterSegmentHostsList>()!;
        }

        [JsiiProperty(name: "segmentSubcluster", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterOutputReference\"}")]
        public virtual yandex.MdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterOutputReference SegmentSubcluster
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.MdbGreenplumClusterSegmentSubclusterOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterTimeoutsOutputReference\"}")]
        public virtual yandex.MdbGreenplumCluster.MdbGreenplumClusterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.MdbGreenplumClusterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessInput", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterAccess\"}", isOptional: true)]
        public virtual yandex.MdbGreenplumCluster.IMdbGreenplumClusterAccess? AccessInput
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.IMdbGreenplumClusterAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "assignPublicIpInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AssignPublicIpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupWindowStartInput", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterBackupWindowStart\"}", isOptional: true)]
        public virtual yandex.MdbGreenplumCluster.IMdbGreenplumClusterBackupWindowStart? BackupWindowStartInput
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.IMdbGreenplumClusterBackupWindowStart?>();
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
        [JsiiProperty(name: "greenplumConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? GreenplumConfigInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
        [JsiiProperty(name: "maintenanceWindowInput", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterMaintenanceWindow\"}", isOptional: true)]
        public virtual yandex.MdbGreenplumCluster.IMdbGreenplumClusterMaintenanceWindow? MaintenanceWindowInput
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.IMdbGreenplumClusterMaintenanceWindow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterHostCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MasterHostCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterSubclusterInput", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterMasterSubcluster\"}", isOptional: true)]
        public virtual yandex.MdbGreenplumCluster.IMdbGreenplumClusterMasterSubcluster? MasterSubclusterInput
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.IMdbGreenplumClusterMasterSubcluster?>();
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
        [JsiiProperty(name: "poolerConfigInput", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterPoolerConfig\"}", isOptional: true)]
        public virtual yandex.MdbGreenplumCluster.IMdbGreenplumClusterPoolerConfig? PoolerConfigInput
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.IMdbGreenplumClusterPoolerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "segmentHostCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SegmentHostCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "segmentInHostInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SegmentInHostInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "segmentSubclusterInput", typeJson: "{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterSegmentSubcluster\"}", isOptional: true)]
        public virtual yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubcluster? SegmentSubclusterInput
        {
            get => GetInstanceProperty<yandex.MdbGreenplumCluster.IMdbGreenplumClusterSegmentSubcluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.mdbGreenplumCluster.MdbGreenplumClusterTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AssignPublicIp
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

        [JsiiProperty(name: "greenplumConfig", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> GreenplumConfig
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
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

        [JsiiProperty(name: "masterHostCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MasterHostCount
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "segmentHostCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SegmentHostCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "segmentInHost", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SegmentInHost
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
