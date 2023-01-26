using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTarget")]
    public class DatatransferEndpointSettingsClickhouseTarget : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTarget
    {
        private object? _altNames;

        /// <summary>alt_names block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#alt_names DatatransferEndpoint#alt_names}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "altNames", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetAltNames\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AltNames
        {
            get => _altNames;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetAltNames[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetAltNames).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _altNames = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#cleanup_policy DatatransferEndpoint#cleanup_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cleanupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CleanupPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#clickhouse_cluster_name DatatransferEndpoint#clickhouse_cluster_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clickhouseClusterName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClickhouseClusterName
        {
            get;
            set;
        }

        /// <summary>connection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#connection DatatransferEndpoint#connection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetConnection\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetConnection? Connection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#security_groups DatatransferEndpoint#security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        /// <summary>sharding block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#sharding DatatransferEndpoint#sharding}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sharding", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetSharding\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetSharding? Sharding
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
