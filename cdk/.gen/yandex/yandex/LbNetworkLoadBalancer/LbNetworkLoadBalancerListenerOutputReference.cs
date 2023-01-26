using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerListenerOutputReference), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LbNetworkLoadBalancerListenerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LbNetworkLoadBalancerListenerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LbNetworkLoadBalancerListenerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbNetworkLoadBalancerListenerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExternalAddressSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerExternalAddressSpec\"}}]")]
        public virtual void PutExternalAddressSpec(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerExternalAddressSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerExternalAddressSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInternalAddressSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerInternalAddressSpec\"}}]")]
        public virtual void PutInternalAddressSpec(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerInternalAddressSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerInternalAddressSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExternalAddressSpec")]
        public virtual void ResetExternalAddressSpec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInternalAddressSpec")]
        public virtual void ResetInternalAddressSpec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProtocol")]
        public virtual void ResetProtocol()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTargetPort")]
        public virtual void ResetTargetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "externalAddressSpec", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerExternalAddressSpecOutputReference\"}")]
        public virtual yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerListenerExternalAddressSpecOutputReference ExternalAddressSpec
        {
            get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerListenerExternalAddressSpecOutputReference>()!;
        }

        [JsiiProperty(name: "internalAddressSpec", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerInternalAddressSpecOutputReference\"}")]
        public virtual yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerListenerInternalAddressSpecOutputReference InternalAddressSpec
        {
            get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerListenerInternalAddressSpecOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalAddressSpecInput", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerExternalAddressSpec\"}", isOptional: true)]
        public virtual yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerExternalAddressSpec? ExternalAddressSpecInput
        {
            get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerExternalAddressSpec?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalAddressSpecInput", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerInternalAddressSpec\"}", isOptional: true)]
        public virtual yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerInternalAddressSpec? InternalAddressSpecInput
        {
            get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerInternalAddressSpec?>();
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
        [JsiiProperty(name: "protocolInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProtocolInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TargetPortInput
        {
            get => GetInstanceProperty<double?>();
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

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListener\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListener cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListener).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
