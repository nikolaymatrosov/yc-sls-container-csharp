using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.Provider
{
    [JsiiByValue(fqn: "yandex.provider.YandexProviderConfig")]
    public class YandexProviderConfig : yandex.Provider.IYandexProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#alias YandexProvider#alias}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alias
        {
            get;
            set;
        }

        /// <summary>ID of Yandex.Cloud tenant.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#cloud_id YandexProvider#cloud_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CloudId
        {
            get;
            set;
        }

        /// <summary>The API endpoint for Yandex.Cloud SDK client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#endpoint YandexProvider#endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Endpoint
        {
            get;
            set;
        }

        /// <summary>The default folder ID where resources will be placed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#folder_id YandexProvider#folder_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FolderId
        {
            get;
            set;
        }

        private object? _insecure;

        /// <summary>Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#insecure YandexProvider#insecure}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Insecure
        {
            get => _insecure;
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
                _insecure = value;
            }
        }

        /// <summary>The maximum number of times an API request is being executed.</summary>
        /// <remarks>
        /// If the API request still fails, an error is thrown.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#max_retries YandexProvider#max_retries}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRetries
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#organization_id YandexProvider#organization_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OrganizationId
        {
            get;
            set;
        }

        private object? _plaintext;

        /// <summary>Disable use of TLS. Default value is `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#plaintext YandexProvider#plaintext}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "plaintext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Plaintext
        {
            get => _plaintext;
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
                _plaintext = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#region_id YandexProvider#region_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RegionId
        {
            get;
            set;
        }

        /// <summary>Either the path to or the contents of a Service Account key file in JSON format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#service_account_key_file YandexProvider#service_account_key_file}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountKeyFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServiceAccountKeyFile
        {
            get;
            set;
        }

        /// <summary>Yandex.Cloud storage service access key.  Used when a storage data/resource doesn't have an access key explicitly specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#storage_access_key YandexProvider#storage_access_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageAccessKey
        {
            get;
            set;
        }

        /// <summary>Yandex.Cloud storage service endpoint. Default is  storage.yandexcloud.net.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#storage_endpoint YandexProvider#storage_endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageEndpoint
        {
            get;
            set;
        }

        /// <summary>Yandex.Cloud storage service secret key.  Used when a storage data/resource doesn't have a secret key explicitly specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#storage_secret_key YandexProvider#storage_secret_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageSecretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StorageSecretKey
        {
            get;
            set;
        }

        /// <summary>The access token for API operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#token YandexProvider#token}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }

        /// <summary>Yandex.Cloud Message Queue service access key.  Used when a message queue resource doesn't have an access key explicitly specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#ymq_access_key YandexProvider#ymq_access_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ymqAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? YmqAccessKey
        {
            get;
            set;
        }

        /// <summary>Yandex.Cloud Message Queue service endpoint. Default is  message-queue.api.cloud.yandex.net.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#ymq_endpoint YandexProvider#ymq_endpoint}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ymqEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? YmqEndpoint
        {
            get;
            set;
        }

        /// <summary>Yandex.Cloud Message Queue service secret key.  Used when a message queue resource doesn't have a secret key explicitly specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#ymq_secret_key YandexProvider#ymq_secret_key}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ymqSecretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? YmqSecretKey
        {
            get;
            set;
        }

        /// <summary>The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#zone YandexProvider#zone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Zone
        {
            get;
            set;
        }
    }
}
