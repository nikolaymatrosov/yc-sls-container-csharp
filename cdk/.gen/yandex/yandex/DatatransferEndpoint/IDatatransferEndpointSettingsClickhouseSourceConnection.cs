using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettingsClickhouseSourceConnection), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnection")]
    public interface IDatatransferEndpointSettingsClickhouseSourceConnection
    {
        /// <summary>connection_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection_options DatatransferEndpoint#connection_options}
        /// </remarks>
        [JsiiProperty(name: "connectionOptions", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptions? ConnectionOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettingsClickhouseSourceConnection), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnection")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSourceConnection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>connection_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection_options DatatransferEndpoint#connection_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionOptions", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptions\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptions? ConnectionOptions
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseSourceConnectionConnectionOptions?>();
            }
        }
    }
}
