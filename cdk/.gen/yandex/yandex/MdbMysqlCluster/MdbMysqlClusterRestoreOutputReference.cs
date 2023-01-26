using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbMysqlCluster.MdbMysqlClusterRestoreOutputReference), fullyQualifiedName: "yandex.mdbMysqlCluster.MdbMysqlClusterRestoreOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbMysqlClusterRestoreOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbMysqlClusterRestoreOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbMysqlClusterRestoreOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbMysqlClusterRestoreOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTime")]
        public virtual void ResetTime()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BackupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "backupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BackupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Time
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterRestore\"}", isOptional: true)]
        public virtual yandex.MdbMysqlCluster.IMdbMysqlClusterRestore? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.IMdbMysqlClusterRestore?>();
            set => SetInstanceProperty(value);
        }
    }
}
