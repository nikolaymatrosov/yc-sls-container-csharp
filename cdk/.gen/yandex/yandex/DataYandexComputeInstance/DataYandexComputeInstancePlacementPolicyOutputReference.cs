using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstance
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyOutputReference), fullyQualifiedName: "yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataYandexComputeInstancePlacementPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataYandexComputeInstancePlacementPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataYandexComputeInstancePlacementPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstancePlacementPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHostAffinityRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyHostAffinityRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHostAffinityRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicyHostAffinityRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicyHostAffinityRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicyHostAffinityRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHostAffinityRules")]
        public virtual void ResetHostAffinityRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementGroupId")]
        public virtual void ResetPlacementGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hostAffinityRules", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyHostAffinityRulesList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyHostAffinityRulesList HostAffinityRules
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyHostAffinityRulesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostAffinityRulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyHostAffinityRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HostAffinityRulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlacementGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlacementGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicy\"}", isOptional: true)]
        public virtual yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicy? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
