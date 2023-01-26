using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DatatransferEndpoint
{
    [JsiiByValue(fqn: "yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremise")]
    public class DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremise : yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremise
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#http_port DatatransferEndpoint#http_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? HttpPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#native_port DatatransferEndpoint#native_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nativePort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NativePort
        {
            get;
            set;
        }

        private object? _shards;

        /// <summary>shards block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#shards DatatransferEndpoint#shards}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shards", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremiseShards\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Shards
        {
            get => _shards;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremiseShards[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremiseShards).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shards = value;
            }
        }

        /// <summary>tls_mode block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/datatransfer_endpoint#tls_mode DatatransferEndpoint#tls_mode}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tlsMode", typeJson: "{\"fqn\":\"yandex.datatransferEndpoint.DatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremiseTlsMode\"}", isOptional: true)]
        public yandex.DatatransferEndpoint.IDatatransferEndpointSettingsClickhouseTargetConnectionConnectionOptionsOnPremiseTlsMode? TlsMode
        {
            get;
            set;
        }
    }
}
