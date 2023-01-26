using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseDedicated
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicy")]
    public class YdbDatabaseDedicatedScalePolicy : yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicy
    {
        /// <summary>fixed_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_dedicated#fixed_scale YdbDatabaseDedicated#fixed_scale}
        /// </remarks>
        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.ydbDatabaseDedicated.YdbDatabaseDedicatedScalePolicyFixedScale\"}")]
        public yandex.YdbDatabaseDedicated.IYdbDatabaseDedicatedScalePolicyFixedScale FixedScale
        {
            get;
            set;
        }
    }
}
