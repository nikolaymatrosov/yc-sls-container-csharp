using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendHealthcheckOutputReference), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbBackendGroupGrpcBackendHealthcheckOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbBackendGroupGrpcBackendHealthcheckOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbBackendGroupGrpcBackendHealthcheckOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbBackendGroupGrpcBackendHealthcheckOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpcHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck\"}}]")]
        public virtual void PutGrpcHealthcheck(yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck\"}}]")]
        public virtual void PutHttpHealthcheck(yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStreamHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck\"}}]")]
        public virtual void PutStreamHealthcheck(yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck)}, new object[]{@value});
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

        [JsiiProperty(name: "grpcHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheckOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheckOutputReference GrpcHealthcheck
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheckOutputReference>()!;
        }

        [JsiiProperty(name: "httpHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckHttpHealthcheckOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendHealthcheckHttpHealthcheckOutputReference HttpHealthcheck
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendHealthcheckHttpHealthcheckOutputReference>()!;
        }

        [JsiiProperty(name: "streamHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckOutputReference StreamHealthcheck
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheckOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcHealthcheckInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck? GrpcHealthcheckInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckGrpcHealthcheck?>();
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
        [JsiiProperty(name: "httpHealthcheckInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck? HttpHealthcheckInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckHttpHealthcheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntervalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalJitterPercentInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntervalJitterPercentInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamHealthcheckInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck? StreamHealthcheckInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheckStreamHealthcheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeoutInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Interval
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "intervalJitterPercent", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IntervalJitterPercent
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Timeout
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnhealthyThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheck\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheck? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheck?>();
            set => SetInstanceProperty(value);
        }
    }
}
