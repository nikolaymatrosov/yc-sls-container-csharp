using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    [JsiiClass(nativeType: typeof(yandex.StorageBucket.StorageBucketServerSideEncryptionConfigurationOutputReference), fullyQualifiedName: "yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class StorageBucketServerSideEncryptionConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public StorageBucketServerSideEncryptionConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected StorageBucketServerSideEncryptionConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageBucketServerSideEncryptionConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRule\"}}]")]
        public virtual void PutRule(yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRule)}, new object[]{@value});
        }

        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRuleOutputReference\"}")]
        public virtual yandex.StorageBucket.StorageBucketServerSideEncryptionConfigurationRuleOutputReference Rule
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketServerSideEncryptionConfigurationRuleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationRule\"}", isOptional: true)]
        public virtual yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRule? RuleInput
        {
            get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketServerSideEncryptionConfigurationRule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfiguration\"}", isOptional: true)]
        public virtual yandex.StorageBucket.IStorageBucketServerSideEncryptionConfiguration? InternalValue
        {
            get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketServerSideEncryptionConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
