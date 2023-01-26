using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    [JsiiClass(nativeType: typeof(yandex.YdbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyOutputReference), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class YdbDatabaseDedicatedScalePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public YdbDatabaseDedicatedScalePolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected YdbDatabaseDedicatedScalePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected YdbDatabaseDedicatedScalePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFixedScale", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScale\"}}]")]
        public virtual void PutFixedScale(yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicyFixedScale @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicyFixedScale)}, new object[]{@value});
        }

        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScaleOutputReference\"}")]
        public virtual yandex.YdbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScaleOutputReference FixedScale
        {
            get => GetInstanceProperty<yandex.YdbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScaleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fixedScaleInput", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScale\"}", isOptional: true)]
        public virtual yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicyFixedScale? FixedScaleInput
        {
            get => GetInstanceProperty<yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicyFixedScale?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicy\"}", isOptional: true)]
        public virtual yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicy? InternalValue
        {
            get => GetInstanceProperty<yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
