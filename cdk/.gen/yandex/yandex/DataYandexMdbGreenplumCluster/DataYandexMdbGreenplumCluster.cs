using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbGreenplumCluster
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster yandex_mdb_greenplum_cluster}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumCluster), fullyQualifiedName: "yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumCluster", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterConfig\"}}]")]
    public class DataYandexMdbGreenplumCluster : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/mdb_greenplum_cluster yandex_mdb_greenplum_cluster} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexMdbGreenplumCluster(Constructs.Construct scope, string id, yandex.DataYandexMdbGreenplumCluster.IDataYandexMdbGreenplumClusterConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexMdbGreenplumCluster.IDataYandexMdbGreenplumClusterConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbGreenplumCluster(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbGreenplumCluster(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPoolerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterPoolerConfig\"}}]")]
        public virtual void PutPoolerConfig(yandex.DataYandexMdbGreenplumCluster.IDataYandexMdbGreenplumClusterPoolerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexMdbGreenplumCluster.IDataYandexMdbGreenplumClusterPoolerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClusterId")]
        public virtual void ResetClusterId()
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

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPoolerConfig")]
        public virtual void ResetPoolerConfig()
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
        = GetStaticProperty<string>(typeof(yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumCluster))!;

        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterAccessList\"}")]
        public virtual yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterAccessList Access
        {
            get => GetInstanceProperty<yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterAccessList>()!;
        }

        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AssignPublicIp
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterBackupWindowStartList\"}")]
        public virtual yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterBackupWindowStartList BackupWindowStart
        {
            get => GetInstanceProperty<yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterBackupWindowStartList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deletionProtection", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DeletionProtection
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterMaintenanceWindowList\"}")]
        public virtual yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterMaintenanceWindowList MaintenanceWindow
        {
            get => GetInstanceProperty<yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterMaintenanceWindowList>()!;
        }

        [JsiiProperty(name: "masterHostCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MasterHostCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "masterHosts", typeJson: "{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterMasterHostsList\"}")]
        public virtual yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterMasterHostsList MasterHosts
        {
            get => GetInstanceProperty<yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterMasterHostsList>()!;
        }

        [JsiiProperty(name: "masterSubcluster", typeJson: "{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterMasterSubclusterList\"}")]
        public virtual yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterMasterSubclusterList MasterSubcluster
        {
            get => GetInstanceProperty<yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterMasterSubclusterList>()!;
        }

        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "poolerConfig", typeJson: "{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterPoolerConfigOutputReference\"}")]
        public virtual yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterPoolerConfigOutputReference PoolerConfig
        {
            get => GetInstanceProperty<yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterPoolerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "segmentHostCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SegmentHostCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "segmentHosts", typeJson: "{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterSegmentHostsList\"}")]
        public virtual yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterSegmentHostsList SegmentHosts
        {
            get => GetInstanceProperty<yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterSegmentHostsList>()!;
        }

        [JsiiProperty(name: "segmentInHost", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SegmentInHost
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "segmentSubcluster", typeJson: "{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterSegmentSubclusterList\"}")]
        public virtual yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterSegmentSubclusterList SegmentSubcluster
        {
            get => GetInstanceProperty<yandex.DataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterSegmentSubclusterList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clusterIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClusterIdInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolerConfigInput", typeJson: "{\"fqn\":\"yandex.dataYandexMdbGreenplumCluster.DataYandexMdbGreenplumClusterPoolerConfig\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbGreenplumCluster.IDataYandexMdbGreenplumClusterPoolerConfig? PoolerConfigInput
        {
            get => GetInstanceProperty<yandex.DataYandexMdbGreenplumCluster.IDataYandexMdbGreenplumClusterPoolerConfig?>();
        }

        [JsiiProperty(name: "clusterId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterId
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
