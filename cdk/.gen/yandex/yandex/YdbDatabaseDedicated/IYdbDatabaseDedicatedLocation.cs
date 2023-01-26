using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    [JsiiInterface(nativeType: typeof(IYdbDatabaseDedicatedLocation), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocation")]
    public interface IYdbDatabaseDedicatedLocation
    {
        /// <summary>region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#region YdbDatabaseDedicated#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocationRegion\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocationRegion? Region
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IYdbDatabaseDedicatedLocation), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocation")]
        internal sealed class _Proxy : DeputyBase, yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>region block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#region YdbDatabaseDedicated#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocationRegion\"}", isOptional: true)]
            public yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocationRegion? Region
            {
                get => GetInstanceProperty<yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocationRegion?>();
            }
        }
    }
}
