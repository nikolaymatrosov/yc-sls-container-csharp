using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash")]
    public class DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#column_name DatatransferEndpoint#column_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ColumnName
        {
            get;
            set;
        }
    }
}
