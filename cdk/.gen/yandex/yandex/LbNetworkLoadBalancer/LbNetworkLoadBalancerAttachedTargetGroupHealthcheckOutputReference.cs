using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHttpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions\"}}]")]
        public virtual void PutHttpOptions(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcpOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions\"}}]")]
        public virtual void PutTcpOptions(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHealthyThreshold")]
        public virtual void ResetHealthyThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpOptions")]
        public virtual void ResetHttpOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInterval")]
        public virtual void ResetInterval()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcpOptions")]
        public virtual void ResetTcpOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeout")]
        public virtual void ResetTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnhealthyThreshold")]
        public virtual void ResetUnhealthyThreshold()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "httpOptions", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptionsOutputReference\"}")]
        public virtual yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptionsOutputReference HttpOptions
        {
            get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsOutputReference\"}")]
        public virtual yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsOutputReference TcpOptions
        {
            get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthyThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HealthyThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpOptionsInput", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions\"}", isOptional: true)]
        public virtual yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions? HttpOptionsInput
        {
            get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "intervalInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IntervalInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpOptionsInput", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions\"}", isOptional: true)]
        public virtual yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions? TcpOptionsInput
        {
            get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unhealthyThresholdInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? UnhealthyThresholdInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthyThreshold
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Interval
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheck\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheck cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheck).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
