using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsMode")]
    public class DatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsMode : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsMode
    {
        /// <summary>disabled block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#disabled DatatransferEndpoint#disabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "disabled", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsModeDisabled\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsModeDisabled? Disabled
        {
            get;
            set;
        }

        /// <summary>enabled block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#enabled DatatransferEndpoint#enabled}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsModeEnabled\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsModeEnabled? Enabled
        {
            get;
            set;
        }
    }
}
