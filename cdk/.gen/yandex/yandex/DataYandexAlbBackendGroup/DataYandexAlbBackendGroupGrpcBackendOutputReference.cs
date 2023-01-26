using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendOutputReference), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexAlbBackendGroupGrpcBackendOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexAlbBackendGroupGrpcBackendOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexAlbBackendGroupGrpcBackendOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexAlbBackendGroupGrpcBackendOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheck\"}}]")]
        public virtual void PutHealthcheck(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoadBalancingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig\"}}]")]
        public virtual void PutLoadBalancingConfig(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTls\"}}]")]
        public virtual void PutTls(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHealthcheck")]
        public virtual void ResetHealthcheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancingConfig")]
        public virtual void ResetLoadBalancingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTls")]
        public virtual void ResetTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWeight")]
        public virtual void ResetWeight()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "healthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheckOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheckOutputReference Healthcheck
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheckOutputReference>()!;
        }

        [JsiiProperty(name: "loadBalancingConfig", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendLoadBalancingConfigOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendLoadBalancingConfigOutputReference LoadBalancingConfig
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendLoadBalancingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTlsOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTlsOutputReference Tls
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthcheckInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendHealthcheck\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheck? HealthcheckInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendHealthcheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingConfigInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig? LoadBalancingConfigInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendTls\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTls? TlsInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendTls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weightInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WeightInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Weight
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackend\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackend cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackend).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
