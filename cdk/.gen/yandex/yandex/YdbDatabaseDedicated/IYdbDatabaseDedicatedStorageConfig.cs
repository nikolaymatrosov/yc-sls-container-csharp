using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    [JsiiInterface(nativeType: typeof(IYdbDatabaseDedicatedStorageConfig), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedStorageConfig")]
    public interface IYdbDatabaseDedicatedStorageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#group_count YdbDatabaseDedicated#group_count}.</summary>
        [JsiiProperty(name: "groupCount", typeJson: "{\"primitive\":\"number\"}")]
        double GroupCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#storage_type_id YdbDatabaseDedicated#storage_type_id}.</summary>
        [JsiiProperty(name: "storageTypeId", typeJson: "{\"primitive\":\"string\"}")]
        string StorageTypeId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IYdbDatabaseDedicatedStorageConfig), fullyQualifiedName: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedStorageConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedStorageConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#group_count YdbDatabaseDedicated#group_count}.</summary>
            [JsiiProperty(name: "groupCount", typeJson: "{\"primitive\":\"number\"}")]
            public double GroupCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#storage_type_id YdbDatabaseDedicated#storage_type_id}.</summary>
            [JsiiProperty(name: "storageTypeId", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageTypeId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
