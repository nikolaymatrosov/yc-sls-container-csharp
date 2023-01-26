using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.AlbBackendGroup.AlbBackendGroupStreamBackendOutputReference), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupStreamBackendOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AlbBackendGroupStreamBackendOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AlbBackendGroupStreamBackendOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AlbBackendGroupStreamBackendOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbBackendGroupStreamBackendOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHealthcheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendHealthcheck\"}}]")]
        public virtual void PutHealthcheck(yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendHealthcheck @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendHealthcheck)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoadBalancingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendLoadBalancingConfig\"}}]")]
        public virtual void PutLoadBalancingConfig(yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendLoadBalancingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendLoadBalancingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendTls\"}}]")]
        public virtual void PutTls(yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendTls)}, new object[]{@value});
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

        [JsiiProperty(name: "healthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendHealthcheckOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupStreamBackendHealthcheckOutputReference Healthcheck
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupStreamBackendHealthcheckOutputReference>()!;
        }

        [JsiiProperty(name: "loadBalancingConfig", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendLoadBalancingConfigOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupStreamBackendLoadBalancingConfigOutputReference LoadBalancingConfig
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupStreamBackendLoadBalancingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendTlsOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupStreamBackendTlsOutputReference Tls
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupStreamBackendTlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableProxyProtocolInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableProxyProtocolInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthcheckInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendHealthcheck\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendHealthcheck? HealthcheckInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendHealthcheck?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingConfigInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendLoadBalancingConfig\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendLoadBalancingConfig? LoadBalancingConfigInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendLoadBalancingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetGroupIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? TargetGroupIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendTls\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendTls? TlsInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendTls?>();
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] TargetGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Weight
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackend\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.AlbBackendGroup.IAlbBackendGroupStreamBackend cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.AlbBackendGroup.IAlbBackendGroupStreamBackend).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
