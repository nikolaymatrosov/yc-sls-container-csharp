using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiClass(nativeType: typeof(yandex.DatatransferEndpoint.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseOutputReference), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTlsMode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsMode\"}}]")]
        public virtual void PutTlsMode(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsMode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsMode)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHosts")]
        public virtual void ResetHosts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicaSet")]
        public virtual void ResetReplicaSet()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsMode")]
        public virtual void ResetTlsMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "tlsMode", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsModeOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsModeOutputReference TlsMode
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsModeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? HostsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicaSetInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicaSetInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsModeInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsMode\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsMode? TlsModeInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremiseTlsMode?>();
        }

        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Hosts
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicaSet", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicaSet
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremise\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremise? InternalValue
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsOnPremise?>();
            set => SetInstanceProperty(value);
        }
    }
}
