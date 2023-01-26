using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiClass(nativeType: typeof(yandex.DatatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeOutputReference), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDisabled", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeDisabled\"}}]")]
        public virtual void PutDisabled(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeDisabled @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeDisabled)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEnabled", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeEnabled\"}}]")]
        public virtual void PutEnabled(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeEnabled @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeEnabled)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDisabled")]
        public virtual void ResetDisabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "disabled", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeDisabledOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeDisabledOutputReference Disabled
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeDisabledOutputReference>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeEnabledOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeEnabledOutputReference Enabled
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeEnabledOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "disabledInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeDisabled\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeDisabled? DisabledInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeDisabled?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeEnabled\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeEnabled? EnabledInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsModeEnabled?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsMode\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsMode? InternalValue
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnectionOnPremiseTlsMode?>();
            set => SetInstanceProperty(value);
        }
    }
}
