using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    [JsiiByValue(fqn: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocation")]
    public class YdbDatabaseDedicatedLocation : yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocation
    {
        /// <summary>region block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#region YdbDatabaseDedicated#region}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedLocationRegion\"}", isOptional: true)]
        public yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedLocationRegion? Region
        {
            get;
            set;
        }
    }
}
