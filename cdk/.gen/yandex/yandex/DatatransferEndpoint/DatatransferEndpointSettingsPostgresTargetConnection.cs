using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTargetConnection")]
    public class DatatransferEndpointSettingsPostgresTargetConnection : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTargetConnection
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mdb_cluster_id DatatransferEndpoint#mdb_cluster_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mdbClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MdbClusterId
        {
            get;
            set;
        }

        /// <summary>on_premise block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#on_premise DatatransferEndpoint#on_premise}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onPremise", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTargetConnectionOnPremise\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTargetConnectionOnPremise? OnPremise
        {
            get;
            set;
        }
    }
}
