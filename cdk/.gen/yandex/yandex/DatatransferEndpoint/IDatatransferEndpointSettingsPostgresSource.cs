using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettingsPostgresSource), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSource")]
    public interface IDatatransferEndpointSettingsPostgresSource
    {
        /// <summary>connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection DatatransferEndpoint#connection}
        /// </remarks>
        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnection? Connection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#database DatatransferEndpoint#database}.</summary>
        [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Database
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#exclude_tables DatatransferEndpoint#exclude_tables}.</summary>
        [JsiiProperty(name: "excludeTables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ExcludeTables
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#include_tables DatatransferEndpoint#include_tables}.</summary>
        [JsiiProperty(name: "includeTables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? IncludeTables
        {
            get
            {
                return null;
            }
        }

        /// <summary>object_transfer_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#object_transfer_settings DatatransferEndpoint#object_transfer_settings}
        /// </remarks>
        [JsiiProperty(name: "objectTransferSettings", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceObjectTransferSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceObjectTransferSettings? ObjectTransferSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#password DatatransferEndpoint#password}
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourcePassword\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourcePassword? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#security_groups DatatransferEndpoint#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#service_schema DatatransferEndpoint#service_schema}.</summary>
        [JsiiProperty(name: "serviceSchema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceSchema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#slot_gigabyte_lag_limit DatatransferEndpoint#slot_gigabyte_lag_limit}.</summary>
        [JsiiProperty(name: "slotGigabyteLagLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SlotGigabyteLagLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#user DatatransferEndpoint#user}.</summary>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? User
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettingsPostgresSource), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSource")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>connection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection DatatransferEndpoint#connection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceConnection\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnection? Connection
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceConnection?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#database DatatransferEndpoint#database}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "database", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Database
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#exclude_tables DatatransferEndpoint#exclude_tables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeTables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ExcludeTables
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#include_tables DatatransferEndpoint#include_tables}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeTables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? IncludeTables
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>object_transfer_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#object_transfer_settings DatatransferEndpoint#object_transfer_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objectTransferSettings", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourceObjectTransferSettings\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceObjectTransferSettings? ObjectTransferSettings
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourceObjectTransferSettings?>();
            }

            /// <summary>password block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#password DatatransferEndpoint#password}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsPostgresSourcePassword\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourcePassword? Password
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsPostgresSourcePassword?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#security_groups DatatransferEndpoint#security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#service_schema DatatransferEndpoint#service_schema}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceSchema", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceSchema
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#slot_gigabyte_lag_limit DatatransferEndpoint#slot_gigabyte_lag_limit}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "slotGigabyteLagLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SlotGigabyteLagLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#user DatatransferEndpoint#user}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? User
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
