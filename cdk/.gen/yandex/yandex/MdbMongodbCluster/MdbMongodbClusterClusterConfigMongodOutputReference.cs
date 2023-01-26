using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodOutputReference), fullyQualifiedName: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbMongodbClusterClusterConfigMongodOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbMongodbClusterClusterConfigMongodOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbMongodbClusterClusterConfigMongodOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbMongodbClusterClusterConfigMongodOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuditLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodAuditLog\"}}]")]
        public virtual void PutAuditLog(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodAuditLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodAuditLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurity\"}}]")]
        public virtual void PutSecurity(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSetParameter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSetParameter\"}}]")]
        public virtual void PutSetParameter(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSetParameter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSetParameter)}, new object[]{@value});
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

        [JsiiProperty(name: "auditLog", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodAuditLogOutputReference\"}")]
        public virtual yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodAuditLogOutputReference AuditLog
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodAuditLogOutputReference>()!;
        }

        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityOutputReference\"}")]
        public virtual yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityOutputReference Security
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityOutputReference>()!;
        }

        [JsiiProperty(name: "setParameter", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSetParameterOutputReference\"}")]
        public virtual yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSetParameterOutputReference SetParameter
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSetParameterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditLogInput", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodAuditLog\"}", isOptional: true)]
        public virtual yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodAuditLog? AuditLogInput
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodAuditLog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityInput", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurity\"}", isOptional: true)]
        public virtual yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity? SecurityInput
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "setParameterInput", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSetParameter\"}", isOptional: true)]
        public virtual yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSetParameter? SetParameterInput
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSetParameter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongod\"}", isOptional: true)]
        public virtual yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongod?>();
            set => SetInstanceProperty(value);
        }
    }
}
