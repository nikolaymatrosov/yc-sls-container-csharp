using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnection")]
    public class DatatransferEndpointSettingsClickhouseSourceConnection : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSourceConnection
    {
        /// <summary>connection_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection_options DatatransferEndpoint#connection_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connectionOptions", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptions\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptions? ConnectionOptions
        {
            get;
            set;
        }
    }
}
