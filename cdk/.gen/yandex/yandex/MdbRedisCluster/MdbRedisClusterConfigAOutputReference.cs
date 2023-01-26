using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbRedisCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbRedisCluster.MdbRedisClusterConfigAOutputReference), fullyQualifiedName: "yandex.mdbRedisCluster.MdbRedisClusterConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbRedisClusterConfigAOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbRedisClusterConfigAOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbRedisClusterConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbRedisClusterConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetClientOutputBufferLimitNormal")]
        public virtual void ResetClientOutputBufferLimitNormal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientOutputBufferLimitPubsub")]
        public virtual void ResetClientOutputBufferLimitPubsub()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabases")]
        public virtual void ResetDatabases()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxmemoryPolicy")]
        public virtual void ResetMaxmemoryPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotifyKeyspaceEvents")]
        public virtual void ResetNotifyKeyspaceEvents()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlowlogLogSlowerThan")]
        public virtual void ResetSlowlogLogSlowerThan()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSlowlogMaxLen")]
        public virtual void ResetSlowlogMaxLen()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientOutputBufferLimitNormalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientOutputBufferLimitNormalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientOutputBufferLimitPubsubInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientOutputBufferLimitPubsubInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databasesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DatabasesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxmemoryPolicyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MaxmemoryPolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notifyKeyspaceEventsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotifyKeyspaceEventsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slowlogLogSlowerThanInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SlowlogLogSlowerThanInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "slowlogMaxLenInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SlowlogMaxLenInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "clientOutputBufferLimitNormal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientOutputBufferLimitNormal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientOutputBufferLimitPubsub", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientOutputBufferLimitPubsub
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "databases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Databases
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxmemoryPolicy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotifyKeyspaceEvents
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "slowlogLogSlowerThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SlowlogLogSlowerThan
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "slowlogMaxLen", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SlowlogMaxLen
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbRedisCluster.MdbRedisClusterConfigA\"}", isOptional: true)]
        public virtual yandex.MdbRedisCluster.IMdbRedisClusterConfigA? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbRedisCluster.IMdbRedisClusterConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
