using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigOutputReference), fullyQualifiedName: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbMongodbClusterClusterConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbMongodbClusterClusterConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbMongodbClusterClusterConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbMongodbClusterClusterConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigAccess\"}}]")]
        public virtual void PutAccess(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackupWindowStart", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigBackupWindowStart\"}}]")]
        public virtual void PutBackupWindowStart(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigBackupWindowStart @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigBackupWindowStart)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMongod", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongod\"}}]")]
        public virtual void PutMongod(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod)}, new object[]{@value});
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

        [JsiiMethod(name: "resetFeatureCompatibilityVersion")]
        public virtual void ResetFeatureCompatibilityVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMongod")]
        public virtual void ResetMongod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigAccessOutputReference\"}")]
        public virtual yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigAccessOutputReference Access
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigAccessOutputReference>()!;
        }

        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigBackupWindowStartOutputReference\"}")]
        public virtual yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigBackupWindowStartOutputReference BackupWindowStart
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigBackupWindowStartOutputReference>()!;
        }

        [JsiiProperty(name: "mongod", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodOutputReference\"}")]
        public virtual yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodOutputReference Mongod
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessInput", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigAccess\"}", isOptional: true)]
        public virtual yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigAccess? AccessInput
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupWindowStartInput", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigBackupWindowStart\"}", isOptional: true)]
        public virtual yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigBackupWindowStart? BackupWindowStartInput
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigBackupWindowStart?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "featureCompatibilityVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FeatureCompatibilityVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mongodInput", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongod\"}", isOptional: true)]
        public virtual yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod? MongodInput
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "featureCompatibilityVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FeatureCompatibilityVersion
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfig\"}", isOptional: true)]
        public virtual yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfig? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
