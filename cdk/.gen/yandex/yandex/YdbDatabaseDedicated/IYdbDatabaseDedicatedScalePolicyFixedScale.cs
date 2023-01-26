using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    [JsiiInterface(nativeType: typeof(IYdbDatabaseDedicatedScalePolicyFixedScale), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScale")]
    public interface IYdbDatabaseDedicatedScalePolicyFixedScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#size YdbDatabaseDedicated#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IYdbDatabaseDedicatedScalePolicyFixedScale), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScale")]
        internal sealed class _Proxy : DeputyBase, yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicyFixedScale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#size YdbDatabaseDedicated#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
