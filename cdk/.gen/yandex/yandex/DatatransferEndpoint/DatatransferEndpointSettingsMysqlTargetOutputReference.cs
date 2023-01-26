using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiClass(nativeType: typeof(yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlTargetOutputReference), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatatransferEndpointSettingsMysqlTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatatransferEndpointSettingsMysqlTargetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatatransferEndpointSettingsMysqlTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatatransferEndpointSettingsMysqlTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnection\"}}]")]
        public virtual void PutConnection(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPassword", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetPassword\"}}]")]
        public virtual void PutPassword(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetPassword @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetPassword)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnection")]
        public virtual void ResetConnection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabase")]
        public virtual void ResetDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPassword")]
        public virtual void ResetPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroups")]
        public virtual void ResetSecurityGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkipConstraintChecks")]
        public virtual void ResetSkipConstraintChecks()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlMode")]
        public virtual void ResetSqlMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimezone")]
        public virtual void ResetTimezone()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUser")]
        public virtual void ResetUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnectionOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnectionOutputReference Connection
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnectionOutputReference>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetPasswordOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlTargetPasswordOutputReference Password
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlTargetPasswordOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnection\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnection? ConnectionInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetPassword\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetPassword? PasswordInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetPassword?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skipConstraintChecksInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? SkipConstraintChecksInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timezoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimezoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Database
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skipConstraintChecks", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object SkipConstraintChecks
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

        [JsiiProperty(name: "sqlMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timezone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timezone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string User
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTarget\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTarget? InternalValue
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
