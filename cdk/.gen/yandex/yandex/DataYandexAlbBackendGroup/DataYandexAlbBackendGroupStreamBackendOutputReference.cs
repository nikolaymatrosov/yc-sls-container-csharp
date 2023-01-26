using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendOutputReference), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexAlbBackendGroupStreamBackendOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexAlbBackendGroupStreamBackendOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexAlbBackendGroupStreamBackendOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexAlbBackendGroupStreamBackendOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendHealthcheck\"}}]")]
        public virtual void PutHealthcheck(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoadBalancingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendLoadBalancingConfig\"}}]")]
        public virtual void PutLoadBalancingConfig(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendLoadBalancingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendLoadBalancingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendTls\"}}]")]
        public virtual void PutTls(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendTls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnableProxyProtocol")]
        public virtual void ResetEnableProxyProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
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

        [JsiiProperty(name: "healthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendHealthcheckOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendHealthcheckOutputReference Healthcheck
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendHealthcheckOutputReference>()!;
        }

        [JsiiProperty(name: "loadBalancingConfig", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendLoadBalancingConfigOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendLoadBalancingConfigOutputReference LoadBalancingConfig
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendLoadBalancingConfigOutputReference>()!;
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

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendTlsOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendTlsOutputReference Tls
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendTlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableProxyProtocolInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableProxyProtocolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthcheckInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendHealthcheck\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendHealthcheck? HealthcheckInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendHealthcheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingConfigInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendLoadBalancingConfig\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendLoadBalancingConfig? LoadBalancingConfigInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendLoadBalancingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendTls\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendTls? TlsInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendTls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weightInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WeightInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "enableProxyProtocol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableProxyProtocol
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackend\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackend cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackend).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
