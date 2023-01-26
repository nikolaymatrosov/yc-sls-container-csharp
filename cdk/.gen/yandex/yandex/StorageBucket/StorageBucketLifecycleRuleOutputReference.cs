using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    [JsiiClass(nativeType: typeof(yandex.StorageBucket.StorageBucketLifecycleRuleOutputReference), fullyQualifiedName: "yandex.storageBucket.StorageBucketLifecycleRuleOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class StorageBucketLifecycleRuleOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public StorageBucketLifecycleRuleOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected StorageBucketLifecycleRuleOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageBucketLifecycleRuleOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExpiration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleExpiration\"}}]")]
        public virtual void PutExpiration(yandex.StorageBucket.IStorageBucketLifecycleRuleExpiration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.StorageBucket.IStorageBucketLifecycleRuleExpiration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoncurrentVersionExpiration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleNoncurrentVersionExpiration\"}}]")]
        public virtual void PutNoncurrentVersionExpiration(yandex.StorageBucket.IStorageBucketLifecycleRuleNoncurrentVersionExpiration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.StorageBucket.IStorageBucketLifecycleRuleNoncurrentVersionExpiration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNoncurrentVersionTransition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleNoncurrentVersionTransition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNoncurrentVersionTransition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.StorageBucket.IStorageBucketLifecycleRuleNoncurrentVersionTransition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketLifecycleRuleNoncurrentVersionTransition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketLifecycleRuleNoncurrentVersionTransition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTransition", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleTransition\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutTransition(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.StorageBucket.IStorageBucketLifecycleRuleTransition[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketLifecycleRuleTransition).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketLifecycleRuleTransition).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAbortIncompleteMultipartUploadDays")]
        public virtual void ResetAbortIncompleteMultipartUploadDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExpiration")]
        public virtual void ResetExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoncurrentVersionExpiration")]
        public virtual void ResetNoncurrentVersionExpiration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNoncurrentVersionTransition")]
        public virtual void ResetNoncurrentVersionTransition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTransition")]
        public virtual void ResetTransition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "expiration", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleExpirationOutputReference\"}")]
        public virtual yandex.StorageBucket.StorageBucketLifecycleRuleExpirationOutputReference Expiration
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketLifecycleRuleExpirationOutputReference>()!;
        }

        [JsiiProperty(name: "noncurrentVersionExpiration", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleNoncurrentVersionExpirationOutputReference\"}")]
        public virtual yandex.StorageBucket.StorageBucketLifecycleRuleNoncurrentVersionExpirationOutputReference NoncurrentVersionExpiration
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketLifecycleRuleNoncurrentVersionExpirationOutputReference>()!;
        }

        [JsiiProperty(name: "noncurrentVersionTransition", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleNoncurrentVersionTransitionList\"}")]
        public virtual yandex.StorageBucket.StorageBucketLifecycleRuleNoncurrentVersionTransitionList NoncurrentVersionTransition
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketLifecycleRuleNoncurrentVersionTransitionList>()!;
        }

        [JsiiProperty(name: "transition", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleTransitionList\"}")]
        public virtual yandex.StorageBucket.StorageBucketLifecycleRuleTransitionList Transition
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketLifecycleRuleTransitionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "abortIncompleteMultipartUploadDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AbortIncompleteMultipartUploadDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expirationInput", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleExpiration\"}", isOptional: true)]
        public virtual yandex.StorageBucket.IStorageBucketLifecycleRuleExpiration? ExpirationInput
        {
            get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketLifecycleRuleExpiration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noncurrentVersionExpirationInput", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleNoncurrentVersionExpiration\"}", isOptional: true)]
        public virtual yandex.StorageBucket.IStorageBucketLifecycleRuleNoncurrentVersionExpiration? NoncurrentVersionExpirationInput
        {
            get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketLifecycleRuleNoncurrentVersionExpiration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "noncurrentVersionTransitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleNoncurrentVersionTransition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NoncurrentVersionTransitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transitionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleTransition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? TransitionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "abortIncompleteMultipartUploadDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AbortIncompleteMultipartUploadDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRule\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.StorageBucket.IStorageBucketLifecycleRule cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.StorageBucket.IStorageBucketLifecycleRule).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
