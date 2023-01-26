using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    [JsiiByValue(fqn: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedTimeouts")]
    public class YdbDatabaseDedicatedTimeouts : yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#default YdbDatabaseDedicated#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}
