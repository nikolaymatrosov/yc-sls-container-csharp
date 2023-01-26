using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigAOutputReference), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbPostgresqlClusterConfigAOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbPostgresqlClusterConfigAOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbPostgresqlClusterConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbPostgresqlClusterConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccess", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigAccess\"}}]")]
        public virtual void PutAccess(yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigAccess @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigAccess)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBackupWindowStart", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStart\"}}]")]
        public virtual void PutBackupWindowStart(yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerformanceDiagnostics", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPerformanceDiagnostics\"}}]")]
        public virtual void PutPerformanceDiagnostics(yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPerformanceDiagnostics @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPerformanceDiagnostics)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPoolerConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfig\"}}]")]
        public virtual void PutPoolerConfig(yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPoolerConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPoolerConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigResources\"}}]")]
        public virtual void PutResources(yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccess")]
        public virtual void ResetAccess()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutofailover")]
        public virtual void ResetAutofailover()
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

        [JsiiMethod(name: "resetPerformanceDiagnostics")]
        public virtual void ResetPerformanceDiagnostics()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPoolerConfig")]
        public virtual void ResetPoolerConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostgresqlConfig")]
        public virtual void ResetPostgresqlConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigAccessOutputReference\"}")]
        public virtual yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigAccessOutputReference Access
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigAccessOutputReference>()!;
        }

        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStartOutputReference\"}")]
        public virtual yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStartOutputReference BackupWindowStart
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStartOutputReference>()!;
        }

        [JsiiProperty(name: "performanceDiagnostics", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPerformanceDiagnosticsOutputReference\"}")]
        public virtual yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigPerformanceDiagnosticsOutputReference PerformanceDiagnostics
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigPerformanceDiagnosticsOutputReference>()!;
        }

        [JsiiProperty(name: "poolerConfig", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfigOutputReference\"}")]
        public virtual yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfigOutputReference PoolerConfig
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfigOutputReference>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigResourcesOutputReference\"}")]
        public virtual yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessInput", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigAccess\"}", isOptional: true)]
        public virtual yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigAccess? AccessInput
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigAccess?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autofailoverInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AutofailoverInput
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
        [JsiiProperty(name: "backupWindowStartInput", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStart\"}", isOptional: true)]
        public virtual yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart? BackupWindowStartInput
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "performanceDiagnosticsInput", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPerformanceDiagnostics\"}", isOptional: true)]
        public virtual yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPerformanceDiagnostics? PerformanceDiagnosticsInput
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPerformanceDiagnostics?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "poolerConfigInput", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigPoolerConfig\"}", isOptional: true)]
        public virtual yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPoolerConfig? PoolerConfigInput
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigPoolerConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postgresqlConfigInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? PostgresqlConfigInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigResources\"}", isOptional: true)]
        public virtual yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autofailover", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Autofailover
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

        [JsiiProperty(name: "postgresqlConfig", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> PostgresqlConfig
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigA\"}", isOptional: true)]
        public virtual yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigA? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
