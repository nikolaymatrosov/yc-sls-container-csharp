using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSource")]
    public class DatatransferEndpointSettingsMongoSource : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSource
    {
        private object? _collections;

        /// <summary>collections block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#collections DatatransferEndpoint#collections}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "collections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSourceCollections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Collections
        {
            get => _collections;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSourceCollections[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSourceCollections).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _collections = value;
            }
        }

        /// <summary>connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection DatatransferEndpoint#connection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSourceConnection\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSourceConnection? Connection
        {
            get;
            set;
        }

        private object? _excludedCollections;

        /// <summary>excluded_collections block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#excluded_collections DatatransferEndpoint#excluded_collections}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludedCollections", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsMongoSourceExcludedCollections\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExcludedCollections
        {
            get => _excludedCollections;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSourceExcludedCollections[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsMongoSourceExcludedCollections).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _excludedCollections = value;
            }
        }

        private object? _secondaryPreferredMode;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#secondary_preferred_mode DatatransferEndpoint#secondary_preferred_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secondaryPreferredMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? SecondaryPreferredMode
        {
            get => _secondaryPreferredMode;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _secondaryPreferredMode = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#security_groups DatatransferEndpoint#security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroups
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
    }
}
