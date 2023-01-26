using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSourceObjectTransferSettings")]
    public class DatatransferEndpointSettingsMysqlSourceObjectTransferSettings : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSourceObjectTransferSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#routine DatatransferEndpoint#routine}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "routine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Routine
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#trigger DatatransferEndpoint#trigger}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Trigger
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#view DatatransferEndpoint#view}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "view", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? View
        {
            get;
            set;
        }
    }
}
