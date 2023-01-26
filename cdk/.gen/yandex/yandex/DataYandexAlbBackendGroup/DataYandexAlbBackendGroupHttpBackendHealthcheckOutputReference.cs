using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckOutputReference), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataYandexAlbBackendGroupHttpBackendHealthcheckOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataYandexAlbBackendGroupHttpBackendHealthcheckOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataYandexAlbBackendGroupHttpBackendHealthcheckOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexAlbBackendGroupHttpBackendHealthcheckOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpcHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck\"}}]")]
        public virtual void PutGrpcHealthcheck(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck\"}}]")]
        public virtual void PutHttpHealthcheck(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStreamHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck\"}}]")]
        public virtual void PutStreamHealthcheck(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrpcHealthcheck")]
        public virtual void ResetGrpcHealthcheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthcheckPort")]
        public virtual void ResetHealthcheckPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthyThreshold")]
        public virtual void ResetHealthyThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpHealthcheck")]
        public virtual void ResetHttpHealthcheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIntervalJitterPercent")]
        public virtual void ResetIntervalJitterPercent()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamHealthcheck")]
        public virtual void ResetStreamHealthcheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnhealthyThreshold")]
        public virtual void ResetUnhealthyThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grpcHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheckOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheckOutputReference GrpcHealthcheck
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheckOutputReference>()!;
        }

        [JsiiProperty(name: "httpHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheckOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheckOutputReference HttpHealthcheck
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheckOutputReference>()!;
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Interval
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "streamHealthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheckOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheckOutputReference StreamHealthcheck
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheckOutputReference>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timeout
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcHealthcheckInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck? GrpcHealthcheckInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthcheckPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthcheckPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthyThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthyThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpHealthcheckInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck? HttpHealthcheckInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalJitterPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntervalJitterPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamHealthcheckInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck? StreamHealthcheckInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unhealthyThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UnhealthyThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "healthcheckPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthcheckPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthyThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "intervalJitterPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalJitterPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnhealthyThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupHttpBackendHealthcheck\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheck? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupHttpBackendHealthcheck?>();
            set => SetInstanceProperty(value);
        }
    }
}
