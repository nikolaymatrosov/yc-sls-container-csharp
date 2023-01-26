using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettingsMysqlSourceObjectTransferSettings), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSourceObjectTransferSettings")]
    public interface IDatatransferEndpointSettingsMysqlSourceObjectTransferSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#routine DatatransferEndpoint#routine}.</summary>
        [JsiiProperty(name: "routine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Routine
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#trigger DatatransferEndpoint#trigger}.</summary>
        [JsiiProperty(name: "trigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Trigger
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#view DatatransferEndpoint#view}.</summary>
        [JsiiProperty(name: "view", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? View
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettingsMysqlSourceObjectTransferSettings), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlSourceObjectTransferSettings")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlSourceObjectTransferSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#routine DatatransferEndpoint#routine}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routine", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Routine
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#trigger DatatransferEndpoint#trigger}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trigger", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Trigger
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#view DatatransferEndpoint#view}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "view", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? View
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
