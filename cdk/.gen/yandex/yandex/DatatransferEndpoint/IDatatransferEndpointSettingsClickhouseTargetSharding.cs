using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettingsClickhouseTargetSharding), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetSharding")]
    public interface IDatatransferEndpointSettingsClickhouseTargetSharding
    {
        /// <summary>column_value_hash block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#column_value_hash DatatransferEndpoint#column_value_hash}
        /// </remarks>
        [JsiiProperty(name: "columnValueHash", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash? ColumnValueHash
        {
            get
            {
                return null;
            }
        }

        /// <summary>transfer_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#transfer_id DatatransferEndpoint#transfer_id}
        /// </remarks>
        [JsiiProperty(name: "transferId", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetShardingTransferId\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetShardingTransferId? TransferId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettingsClickhouseTargetSharding), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetSharding")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetSharding
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>column_value_hash block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#column_value_hash DatatransferEndpoint#column_value_hash}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "columnValueHash", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash? ColumnValueHash
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetShardingColumnValueHash?>();
            }

            /// <summary>transfer_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#transfer_id DatatransferEndpoint#transfer_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "transferId", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetShardingTransferId\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetShardingTransferId? TransferId
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetShardingTransferId?>();
            }
        }
    }
}
