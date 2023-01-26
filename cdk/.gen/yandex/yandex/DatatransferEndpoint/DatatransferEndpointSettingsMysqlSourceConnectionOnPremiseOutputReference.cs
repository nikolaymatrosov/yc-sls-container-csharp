using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiClass(nativeType: typeof(yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseOutputReference), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTlsMode", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsMode\"}}]")]
        public virtual void PutTlsMode(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsMode @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsMode)}, new object[]{@value});
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

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsMode")]
        public virtual void ResetTlsMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "tlsMode", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsModeOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsModeOutputReference TlsMode
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsModeOutputReference>()!;
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
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsModeInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsMode\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsMode? TlsModeInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSourceConnectionOnPremiseTlsMode?>();
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

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSourceConnectionOnPremise\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSourceConnectionOnPremise? InternalValue
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSourceConnectionOnPremise?>();
            set => SetInstanceProperty(value);
        }
    }
}
