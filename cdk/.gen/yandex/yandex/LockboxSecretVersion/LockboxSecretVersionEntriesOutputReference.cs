using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LockboxSecretVersion
{
    [JsiiClass(nativeType: typeof(yandex.LockboxSecretVersion.LockboxSecretVersionEntriesOutputReference), fullyQualifiedName: "yandex.lockboxSecretVersion.LockboxSecretVersionEntriesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class LockboxSecretVersionEntriesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public LockboxSecretVersionEntriesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected LockboxSecretVersionEntriesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LockboxSecretVersionEntriesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCommand", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.lockboxSecretVersion.LockboxSecretVersionEntriesCommand\"}}]")]
        public virtual void PutCommand(yandex.LockboxSecretVersion.ILockboxSecretVersionEntriesCommand @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.LockboxSecretVersion.ILockboxSecretVersionEntriesCommand)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCommand")]
        public virtual void ResetCommand()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTextValue")]
        public virtual void ResetTextValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "command", typeJson: "{\"fqn\":\"yandex.lockboxSecretVersion.LockboxSecretVersionEntriesCommandOutputReference\"}")]
        public virtual yandex.LockboxSecretVersion.LockboxSecretVersionEntriesCommandOutputReference Command
        {
            get => GetInstanceProperty<yandex.LockboxSecretVersion.LockboxSecretVersionEntriesCommandOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "commandInput", typeJson: "{\"fqn\":\"yandex.lockboxSecretVersion.LockboxSecretVersionEntriesCommand\"}", isOptional: true)]
        public virtual yandex.LockboxSecretVersion.ILockboxSecretVersionEntriesCommand? CommandInput
        {
            get => GetInstanceProperty<yandex.LockboxSecretVersion.ILockboxSecretVersionEntriesCommand?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TextValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Key
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "textValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TextValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.lockboxSecretVersion.LockboxSecretVersionEntries\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.LockboxSecretVersion.ILockboxSecretVersionEntries cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.LockboxSecretVersion.ILockboxSecretVersionEntries).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
