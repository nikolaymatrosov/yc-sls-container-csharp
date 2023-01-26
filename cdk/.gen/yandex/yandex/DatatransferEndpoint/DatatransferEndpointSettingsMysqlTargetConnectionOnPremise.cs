using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnectionOnPremise")]
    public class DatatransferEndpointSettingsMysqlTargetConnectionOnPremise : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnectionOnPremise
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#hosts DatatransferEndpoint#hosts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hosts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Hosts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#port DatatransferEndpoint#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#subnet_id DatatransferEndpoint#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }

        /// <summary>tls_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#tls_mode DatatransferEndpoint#tls_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tlsMode", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsMode\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnectionOnPremiseTlsMode? TlsMode
        {
            get;
            set;
        }
    }
}
