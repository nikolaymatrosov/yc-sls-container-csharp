using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettingsClickhouseTargetConnection), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetConnection")]
    public interface IDatatransferEndpointSettingsClickhouseTargetConnection
    {
        /// <summary>connection_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection_options DatatransferEndpoint#connection_options}
        /// </remarks>
        [JsiiProperty(name: "connectionOptions", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptions? ConnectionOptions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettingsClickhouseTargetConnection), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetConnection")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetConnection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>connection_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection_options DatatransferEndpoint#connection_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connectionOptions", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptions\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptions? ConnectionOptions
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptions?>();
            }
        }
    }
}
