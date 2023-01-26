using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    [JsiiInterface(nativeType: typeof(IYdbDatabaseDedicatedScalePolicy), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicy")]
    public interface IYdbDatabaseDedicatedScalePolicy
    {
        /// <summary>fixed_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#fixed_scale YdbDatabaseDedicated#fixed_scale}
        /// </remarks>
        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScale\"}")]
        yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicyFixedScale FixedScale
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IYdbDatabaseDedicatedScalePolicy), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>fixed_scale block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#fixed_scale YdbDatabaseDedicated#fixed_scale}
            /// </remarks>
            [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScale\"}")]
            public yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicyFixedScale FixedScale
            {
                get => GetInstanceProperty<yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicyFixedScale>()!;
            }
        }
    }
}
