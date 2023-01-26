using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsModeEnabled), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsModeEnabled")]
    public interface IDatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsModeEnabled
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#ca_certificate DatatransferEndpoint#ca_certificate}.</summary>
        [JsiiProperty(name: "caCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CaCertificate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsModeEnabled), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsModeEnabled")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresTargetConnectionOnPremiseTlsModeEnabled
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#ca_certificate DatatransferEndpoint#ca_certificate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CaCertificate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
