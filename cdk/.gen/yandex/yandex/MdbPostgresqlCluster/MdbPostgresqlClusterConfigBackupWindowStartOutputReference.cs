using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStartOutputReference), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStartOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbPostgresqlClusterConfigBackupWindowStartOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbPostgresqlClusterConfigBackupWindowStartOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbPostgresqlClusterConfigBackupWindowStartOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbPostgresqlClusterConfigBackupWindowStartOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetHours")]
        public virtual void ResetHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinutes")]
        public virtual void ResetMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "hoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Hours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Minutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigBackupWindowStart\"}", isOptional: true)]
        public virtual yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigBackupWindowStart?>();
            set => SetInstanceProperty(value);
        }
    }
}
