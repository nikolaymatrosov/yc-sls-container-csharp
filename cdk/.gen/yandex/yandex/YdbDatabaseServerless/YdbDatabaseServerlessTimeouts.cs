using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseServerless
{
    [JsiiByValue(fqn: "yandex.ydbDatabaseServerless.YdbDatabaseServerlessTimeouts")]
    public class YdbDatabaseServerlessTimeouts : yandex.YdbDatabaseServerless.IYdbDatabaseServerlessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_serverless#default YdbDatabaseServerless#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}
