using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetSharding")]
    public class DatatransferEndpointSettingsClickhouseTargetSharding : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetSharding
    {
        /// <summary>column_value_hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#column_value_hash DatatransferEndpoint#column_value_hash}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "columnValueHash", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash? ColumnValueHash
        {
            get;
            set;
        }

        /// <summary>transfer_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#transfer_id DatatransferEndpoint#transfer_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "transferId", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetShardingTransferId\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetShardingTransferId? TransferId
        {
            get;
            set;
        }
    }
}
