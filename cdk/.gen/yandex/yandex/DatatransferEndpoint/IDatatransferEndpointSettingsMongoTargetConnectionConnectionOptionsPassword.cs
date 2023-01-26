using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsPassword), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsPassword")]
    public interface IDatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsPassword
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#raw DatatransferEndpoint#raw}.</summary>
        [JsiiProperty(name: "raw", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Raw
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsPassword), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsPassword")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoTargetConnectionConnectionOptionsPassword
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#raw DatatransferEndpoint#raw}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "raw", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Raw
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
