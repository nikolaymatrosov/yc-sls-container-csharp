using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedStorageConfig")]
    public class YdbDatabaseDedicatedStorageConfig : yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedStorageConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#group_count YdbDatabaseDedicated#group_count}.</summary>
        [JsiiProperty(name: "groupCount", typeJson: "{\"primitive\":\"number\"}")]
        public double GroupCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#storage_type_id YdbDatabaseDedicated#storage_type_id}.</summary>
        [JsiiProperty(name: "storageTypeId", typeJson: "{\"primitive\":\"string\"}")]
        public string StorageTypeId
        {
            get;
            set;
        }
    }
}
