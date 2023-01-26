using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    [JsiiInterface(nativeType: typeof(IYdbDatabaseDedicatedLocationRegion), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocationRegion")]
    public interface IYdbDatabaseDedicatedLocationRegion
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#id YdbDatabaseDedicated#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        string Id
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IYdbDatabaseDedicatedLocationRegion), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocationRegion")]
        internal sealed class _Proxy : DeputyBase, yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocationRegion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#id YdbDatabaseDedicated#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
            public string Id
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
