using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstance
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance yandex_compute_instance}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexComputeInstance.DataYandexComputeInstance), fullyQualifiedName: "yandex.dataYandexComputeInstance.DataYandexComputeInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceConfig\"}}]")]
    public class DataYandexComputeInstance : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance yandex_compute_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexComputeInstance(Constructs.Construct scope, string id, yandex.DataYandexComputeInstance.IDataYandexComputeInstanceConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexComputeInstance.IDataYandexComputeInstanceConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstance(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFilesystem", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceFilesystem\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFilesystem(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.DataYandexComputeInstance.IDataYandexComputeInstanceFilesystem[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataYandexComputeInstance.IDataYandexComputeInstanceFilesystem).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataYandexComputeInstance.IDataYandexComputeInstanceFilesystem).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLocalDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceLocalDisk\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLocalDisk(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.DataYandexComputeInstance.IDataYandexComputeInstanceLocalDisk[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataYandexComputeInstance.IDataYandexComputeInstanceLocalDisk).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataYandexComputeInstance.IDataYandexComputeInstanceLocalDisk).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMetadataOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceMetadataOptions\"}}]")]
        public virtual void PutMetadataOptions(yandex.DataYandexComputeInstance.IDataYandexComputeInstanceMetadataOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexComputeInstance.IDataYandexComputeInstanceMetadataOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacementPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicy\"}}]")]
        public virtual void PutPlacementPolicy(yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFilesystem")]
        public virtual void ResetFilesystem()
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

        [JsiiMethod(name: "resetInstanceId")]
        public virtual void ResetInstanceId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLocalDisk")]
        public virtual void ResetLocalDisk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadataOptions")]
        public virtual void ResetMetadataOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementPolicy")]
        public virtual void ResetPlacementPolicy()
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
        = GetStaticProperty<string>(typeof(yandex.DataYandexComputeInstance.DataYandexComputeInstance))!;

        [JsiiProperty(name: "bootDisk", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceBootDiskList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceBootDiskList BootDisk
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceBootDiskList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceFilesystemList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceFilesystemList Filesystem
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceFilesystemList>()!;
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "localDisk", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceLocalDiskList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceLocalDiskList LocalDisk
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceLocalDiskList>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Metadata
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "metadataOptions", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceMetadataOptionsOutputReference\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceMetadataOptionsOutputReference MetadataOptions
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceMetadataOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "networkAccelerationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkAccelerationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "placementPolicy", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyOutputReference\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyOutputReference PlacementPolicy
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "platformId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceResourcesList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceResourcesList Resources
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceResourcesList>()!;
        }

        [JsiiProperty(name: "schedulingPolicy", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceSchedulingPolicyList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceSchedulingPolicyList SchedulingPolicy
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceSchedulingPolicyList>()!;
        }

        [JsiiProperty(name: "secondaryDisk", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceSecondaryDiskList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceSecondaryDiskList SecondaryDisk
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceSecondaryDiskList>()!;
        }

        [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "filesystemInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceFilesystem\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FilesystemInput
        {
            get => GetInstanceProperty<object?>();
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
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "localDiskInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceLocalDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LocalDiskInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataOptionsInput", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceMetadataOptions\"}", isOptional: true)]
        public virtual yandex.DataYandexComputeInstance.IDataYandexComputeInstanceMetadataOptions? MetadataOptionsInput
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.IDataYandexComputeInstanceMetadataOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementPolicyInput", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicy\"}", isOptional: true)]
        public virtual yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicy? PlacementPolicyInput
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicy?>();
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

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
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
