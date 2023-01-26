using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettingsClickhouseTargetAltNames), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetAltNames")]
    public interface IDatatransferEndpointSettingsClickhouseTargetAltNames
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#from_name DatatransferEndpoint#from_name}.</summary>
        [JsiiProperty(name: "fromName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FromName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#to_name DatatransferEndpoint#to_name}.</summary>
        [JsiiProperty(name: "toName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ToName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettingsClickhouseTargetAltNames), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetAltNames")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetAltNames
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#from_name DatatransferEndpoint#from_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fromName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FromName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#to_name DatatransferEndpoint#to_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "toName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ToName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
