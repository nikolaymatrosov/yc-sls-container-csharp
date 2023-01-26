using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiClass(nativeType: typeof(yandex.DatatransferEndpoint.DatatransferEndpointSettingsOutputReference), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DatatransferEndpointSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DatatransferEndpointSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DatatransferEndpointSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatatransferEndpointSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClickhouseSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSource\"}}]")]
        public virtual void PutClickhouseSource(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putClickhouseTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTarget\"}}]")]
        public virtual void PutClickhouseTarget(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMongoSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSource\"}}]")]
        public virtual void PutMongoSource(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMongoTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTarget\"}}]")]
        public virtual void PutMongoTarget(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMysqlSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSource\"}}]")]
        public virtual void PutMysqlSource(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMysqlTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTarget\"}}]")]
        public virtual void PutMysqlTarget(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPostgresSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSource\"}}]")]
        public virtual void PutPostgresSource(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPostgresTarget", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTarget\"}}]")]
        public virtual void PutPostgresTarget(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTarget @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTarget)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClickhouseSource")]
        public virtual void ResetClickhouseSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClickhouseTarget")]
        public virtual void ResetClickhouseTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMongoSource")]
        public virtual void ResetMongoSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMongoTarget")]
        public virtual void ResetMongoTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMysqlSource")]
        public virtual void ResetMysqlSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMysqlTarget")]
        public virtual void ResetMysqlTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostgresSource")]
        public virtual void ResetPostgresSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPostgresTarget")]
        public virtual void ResetPostgresTarget()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clickhouseSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceOutputReference ClickhouseSource
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceOutputReference>()!;
        }

        [JsiiProperty(name: "clickhouseTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetOutputReference ClickhouseTarget
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetOutputReference>()!;
        }

        [JsiiProperty(name: "mongoSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSourceOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsMongoSourceOutputReference MongoSource
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsMongoSourceOutputReference>()!;
        }

        [JsiiProperty(name: "mongoTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTargetOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsMongoTargetOutputReference MongoTarget
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsMongoTargetOutputReference>()!;
        }

        [JsiiProperty(name: "mysqlSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSourceOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlSourceOutputReference MysqlSource
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlSourceOutputReference>()!;
        }

        [JsiiProperty(name: "mysqlTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlTargetOutputReference MysqlTarget
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsMysqlTargetOutputReference>()!;
        }

        [JsiiProperty(name: "postgresSource", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsPostgresSourceOutputReference PostgresSource
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsPostgresSourceOutputReference>()!;
        }

        [JsiiProperty(name: "postgresTarget", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTargetOutputReference\"}")]
        public virtual yandex.DatatransferEndpoint.DatatransferEndpointSettingsPostgresTargetOutputReference PostgresTarget
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.DatatransferEndpointSettingsPostgresTargetOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clickhouseSourceInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSource\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSource? ClickhouseSourceInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clickhouseTargetInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTarget\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTarget? ClickhouseTargetInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mongoSourceInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSource\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSource? MongoSourceInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mongoTargetInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTarget\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTarget? MongoTargetInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mysqlSourceInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSource\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSource? MysqlSourceInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mysqlTargetInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTarget\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTarget? MysqlTargetInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postgresSourceInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSource\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSource? PostgresSourceInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "postgresTargetInput", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTarget\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTarget? PostgresTargetInput
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTarget?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettings\"}", isOptional: true)]
        public virtual yandex.DatatransferEndpoint.IDatatransferEndpointSettings? InternalValue
        {
            get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
