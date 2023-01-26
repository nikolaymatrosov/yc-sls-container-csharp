using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.AlbBackendGroup.AlbBackendGroupHttpBackendHealthcheckOutputReference), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbBackendGroupHttpBackendHealthcheckOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbBackendGroupHttpBackendHealthcheckOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbBackendGroupHttpBackendHealthcheckOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbBackendGroupHttpBackendHealthcheckOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpcHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck\"}}]")]
        public virtual void PutGrpcHealthcheck(yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckHttpHealthcheck\"}}]")]
        public virtual void PutHttpHealthcheck(yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStreamHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckStreamHealthcheck\"}}]")]
        public virtual void PutStreamHealthcheck(yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck)}, new object[]{@value});
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

        [JsiiProperty(name: "grpcHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckGrpcHealthcheckOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupHttpBackendHealthcheckGrpcHealthcheckOutputReference GrpcHealthcheck
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupHttpBackendHealthcheckGrpcHealthcheckOutputReference>()!;
        }

        [JsiiProperty(name: "httpHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckHttpHealthcheckOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupHttpBackendHealthcheckHttpHealthcheckOutputReference HttpHealthcheck
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupHttpBackendHealthcheckHttpHealthcheckOutputReference>()!;
        }

        [JsiiProperty(name: "streamHealthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckStreamHealthcheckOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupHttpBackendHealthcheckStreamHealthcheckOutputReference StreamHealthcheck
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupHttpBackendHealthcheckStreamHealthcheckOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcHealthcheckInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck? GrpcHealthcheckInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck?>();
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
        [JsiiProperty(name: "httpHealthcheckInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckHttpHealthcheck\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck? HttpHealthcheckInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckHttpHealthcheck?>();
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
        [JsiiProperty(name: "streamHealthcheckInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckStreamHealthcheck\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck? StreamHealthcheckInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckStreamHealthcheck?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheck\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheck? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheck?>();
            set => SetInstanceProperty(value);
        }
    }
}
