using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiInterface(nativeType: typeof(IDatatransferEndpointSettingsMongoSource), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSource")]
    public interface IDatatransferEndpointSettingsMongoSource
    {
        /// <summary>collections block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#collections DatatransferEndpoint#collections}
        /// </remarks>
        [JsiiProperty(name: "collections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSourceCollections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Collections
        {
            get
            {
                return null;
            }
        }

        /// <summary>connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection DatatransferEndpoint#connection}
        /// </remarks>
        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSourceConnection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSourceConnection? Connection
        {
            get
            {
                return null;
            }
        }

        /// <summary>excluded_collections block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#excluded_collections DatatransferEndpoint#excluded_collections}
        /// </remarks>
        [JsiiProperty(name: "excludedCollections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSourceExcludedCollections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludedCollections
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#secondary_preferred_mode DatatransferEndpoint#secondary_preferred_mode}.</summary>
        [JsiiProperty(name: "secondaryPreferredMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SecondaryPreferredMode
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#subnet_id DatatransferEndpoint#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatatransferEndpointSettingsMongoSource), fullyQualifiedName: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSource")]
        internal sealed class _Proxy : DeputyBase, yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>collections block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#collections DatatransferEndpoint#collections}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "collections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSourceCollections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Collections
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>connection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection DatatransferEndpoint#connection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSourceConnection\"}", isOptional: true)]
            public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSourceConnection? Connection
            {
                get => GetInstanceProperty<yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSourceConnection?>();
            }

            /// <summary>excluded_collections block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#excluded_collections DatatransferEndpoint#excluded_collections}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludedCollections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSourceExcludedCollections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ExcludedCollections
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#secondary_preferred_mode DatatransferEndpoint#secondary_preferred_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secondaryPreferredMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SecondaryPreferredMode
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#security_groups DatatransferEndpoint#security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#subnet_id DatatransferEndpoint#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
