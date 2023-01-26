using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiClass(nativeType: typeof(yandex.DatatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceOutputReference), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatatransferEndpointSettingsClickhouseSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatatransferEndpointSettingsClickhouseSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatatransferEndpointSettingsClickhouseSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatatransferEndpointSettingsClickhouseSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnection\"}}]")]
        public virtual void PutConnection(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSourceConnection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSourceConnection)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnection")]
        public virtual void ResetConnection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExcludeTables")]
        public virtual void ResetExcludeTables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeTables")]
        public virtual void ResetIncludeTables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroups")]
        public virtual void ResetSecurityGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnectionOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnectionOutputReference Connection
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnectionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnection\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSourceConnection? ConnectionInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSourceConnection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeTablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? ExcludeTablesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeTablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? IncludeTablesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "excludeTables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExcludeTables
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "includeTables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IncludeTables
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSource\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSource? InternalValue
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
