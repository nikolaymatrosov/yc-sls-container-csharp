using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsMode")]
    public class DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsMode : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsMode
    {
        /// <summary>disabled block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#disabled DatatransferEndpoint#disabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disabled", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsModeDisabled\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsModeDisabled? Disabled
        {
            get;
            set;
        }

        /// <summary>enabled block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#enabled DatatransferEndpoint#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsModeEnabled\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsModeEnabled? Enabled
        {
            get;
            set;
        }
    }
}
