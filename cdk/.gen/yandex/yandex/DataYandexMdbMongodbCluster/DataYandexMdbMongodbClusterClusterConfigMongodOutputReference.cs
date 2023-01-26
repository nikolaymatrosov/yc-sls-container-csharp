using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMongodbCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodOutputReference), fullyQualifiedName: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataYandexMdbMongodbClusterClusterConfigMongodOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataYandexMdbMongodbClusterClusterConfigMongodOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataYandexMdbMongodbClusterClusterConfigMongodOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbMongodbClusterClusterConfigMongodOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuditLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodAuditLog\"}}]")]
        public virtual void PutAuditLog(yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodAuditLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodAuditLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurity\"}}]")]
        public virtual void PutSecurity(yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetParameter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSetParameter\"}}]")]
        public virtual void PutSetParameter(yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSetParameter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSetParameter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuditLog")]
        public virtual void ResetAuditLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurity")]
        public virtual void ResetSecurity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSetParameter")]
        public virtual void ResetSetParameter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "auditLog", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodAuditLogOutputReference\"}")]
        public virtual yandex.DataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodAuditLogOutputReference AuditLog
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodAuditLogOutputReference>()!;
        }

        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityOutputReference\"}")]
        public virtual yandex.DataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityOutputReference Security
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityOutputReference>()!;
        }

        [JsiiProperty(name: "setParameter", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSetParameterOutputReference\"}")]
        public virtual yandex.DataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSetParameterOutputReference SetParameter
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSetParameterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditLogInput", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodAuditLog\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodAuditLog? AuditLogInput
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodAuditLog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityInput", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurity\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurity? SecurityInput
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setParameterInput", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSetParameter\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSetParameter? SetParameterInput
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSetParameter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongod\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongod? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongod?>();
            set => SetInstanceProperty(value);
        }
    }
}
