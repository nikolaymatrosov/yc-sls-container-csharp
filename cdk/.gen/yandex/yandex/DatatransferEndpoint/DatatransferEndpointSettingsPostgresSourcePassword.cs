using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourcePassword")]
    public class DatatransferEndpointSettingsPostgresSourcePassword : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourcePassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#raw DatatransferEndpoint#raw}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "raw", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Raw
        {
            get;
            set;
        }
    }
}
