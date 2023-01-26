using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetAltNames")]
    public class DatatransferEndpointSettingsClickhouseTargetAltNames : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetAltNames
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#from_name DatatransferEndpoint#from_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fromName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FromName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#to_name DatatransferEndpoint#to_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ToName
        {
            get;
            set;
        }
    }
}
