using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbMysqlCluster.MdbMysqlClusterUserConnectionLimitsOutputReference), fullyQualifiedName: "yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimitsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbMysqlClusterUserConnectionLimitsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbMysqlClusterUserConnectionLimitsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbMysqlClusterUserConnectionLimitsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbMysqlClusterUserConnectionLimitsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxConnectionsPerHour")]
        public virtual void ResetMaxConnectionsPerHour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxQuestionsPerHour")]
        public virtual void ResetMaxQuestionsPerHour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxUpdatesPerHour")]
        public virtual void ResetMaxUpdatesPerHour()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxUserConnections")]
        public virtual void ResetMaxUserConnections()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConnectionsPerHourInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConnectionsPerHourInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxQuestionsPerHourInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxQuestionsPerHourInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxUpdatesPerHourInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxUpdatesPerHourInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxUserConnectionsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxUserConnectionsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxConnectionsPerHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConnectionsPerHour
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxQuestionsPerHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxQuestionsPerHour
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxUpdatesPerHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUpdatesPerHour
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxUserConnections", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxUserConnections
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimits\"}", isOptional: true)]
        public virtual yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits?>();
            set => SetInstanceProperty(value);
        }
    }
}
