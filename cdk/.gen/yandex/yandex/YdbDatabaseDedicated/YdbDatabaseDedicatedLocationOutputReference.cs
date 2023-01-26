using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    [JsiiClass(nativeType: typeof(yandex.YdbDatabaseDedicated.YdbDatabaseDedicatedLocationOutputReference), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class YdbDatabaseDedicatedLocationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public YdbDatabaseDedicatedLocationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected YdbDatabaseDedicatedLocationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected YdbDatabaseDedicatedLocationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRegion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocationRegion\"}}]")]
        public virtual void PutRegion(yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocationRegion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocationRegion)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocationRegionOutputReference\"}")]
        public virtual yandex.YdbDatabaseDedicated.YdbDatabaseDedicatedLocationRegionOutputReference Region
        {
            get => GetInstanceProperty<yandex.YdbDatabaseDedicated.YdbDatabaseDedicatedLocationRegionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocationRegion\"}", isOptional: true)]
        public virtual yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocationRegion? RegionInput
        {
            get => GetInstanceProperty<yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocationRegion?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocation\"}", isOptional: true)]
        public virtual yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocation? InternalValue
        {
            get => GetInstanceProperty<yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocation?>();
            set => SetInstanceProperty(value);
        }
    }
}
