using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScale")]
    public class YdbDatabaseDedicatedScalePolicyFixedScale : yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicyFixedScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#size YdbDatabaseDedicated#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }
    }
}
