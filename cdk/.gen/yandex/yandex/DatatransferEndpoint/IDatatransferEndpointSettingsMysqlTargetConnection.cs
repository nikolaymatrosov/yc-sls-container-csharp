using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettingsMysqlTargetConnection), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnection")]
    public interface IDatatransferEndpointSettingsMysqlTargetConnection
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mdb_cluster_id DatatransferEndpoint#mdb_cluster_id}.</summary>
        [JsiiProperty(name: "mdbClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MdbClusterId
        {
            get
            {
                return null;
            }
        }

        /// <summary>on_premise block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#on_premise DatatransferEndpoint#on_premise}
        /// </remarks>
        [JsiiProperty(name: "onPremise", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnectionOnPremise\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnectionOnPremise? OnPremise
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettingsMysqlTargetConnection), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnection")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#mdb_cluster_id DatatransferEndpoint#mdb_cluster_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mdbClusterId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MdbClusterId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>on_premise block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#on_premise DatatransferEndpoint#on_premise}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "onPremise", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMysqlTargetConnectionOnPremise\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnectionOnPremise? OnPremise
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMysqlTargetConnectionOnPremise?>();
            }
        }
    }
}
