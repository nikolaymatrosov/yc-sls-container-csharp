using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.Provider
{
    [JsiiInterface(nativeType: typeof(IYandexProviderConfig), fullyQualifiedName: "yandex.provider.YandexProviderConfig")]
    public interface IYandexProviderConfig
    {
        /// <summary>Alias name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#alias YandexProvider#alias}
        /// </remarks>
        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alias
        {
            get
            {
                return null;
            }
        }

        /// <summary>ID of Yandex.Cloud tenant.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#cloud_id YandexProvider#cloud_id}
        /// </remarks>
        [JsiiProperty(name: "cloudId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CloudId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The API endpoint for Yandex.Cloud SDK client.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#endpoint YandexProvider#endpoint}
        /// </remarks>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Endpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>The default folder ID where resources will be placed.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#folder_id YandexProvider#folder_id}
        /// </remarks>
        [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FolderId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#insecure YandexProvider#insecure}
        /// </remarks>
        [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Insecure
        {
            get
            {
                return null;
            }
        }

        /// <summary>The maximum number of times an API request is being executed.</summary>
        /// <remarks>
        /// If the API request still fails, an error is thrown.
        ///
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#max_retries YandexProvider#max_retries}
        /// </remarks>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRetries
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#organization_id YandexProvider#organization_id}.</summary>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OrganizationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Disable use of TLS. Default value is `false`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#plaintext YandexProvider#plaintext}
        /// </remarks>
        [JsiiProperty(name: "plaintext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Plaintext
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#region_id YandexProvider#region_id}.</summary>
        [JsiiProperty(name: "regionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RegionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Either the path to or the contents of a Service Account key file in JSON format.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#service_account_key_file YandexProvider#service_account_key_file}
        /// </remarks>
        [JsiiProperty(name: "serviceAccountKeyFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceAccountKeyFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>Yandex.Cloud storage service access key.  Used when a storage data/resource doesn't have an access key explicitly specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#storage_access_key YandexProvider#storage_access_key}
        /// </remarks>
        [JsiiProperty(name: "storageAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageAccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Yandex.Cloud storage service endpoint. Default is  storage.yandexcloud.net.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#storage_endpoint YandexProvider#storage_endpoint}
        /// </remarks>
        [JsiiProperty(name: "storageEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Yandex.Cloud storage service secret key.  Used when a storage data/resource doesn't have a secret key explicitly specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#storage_secret_key YandexProvider#storage_secret_key}
        /// </remarks>
        [JsiiProperty(name: "storageSecretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageSecretKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>The access token for API operations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#token YandexProvider#token}
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        /// <summary>Yandex.Cloud Message Queue service access key.  Used when a message queue resource doesn't have an access key explicitly specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#ymq_access_key YandexProvider#ymq_access_key}
        /// </remarks>
        [JsiiProperty(name: "ymqAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? YmqAccessKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Yandex.Cloud Message Queue service endpoint. Default is  message-queue.api.cloud.yandex.net.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#ymq_endpoint YandexProvider#ymq_endpoint}
        /// </remarks>
        [JsiiProperty(name: "ymqEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? YmqEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Yandex.Cloud Message Queue service secret key.  Used when a message queue resource doesn't have a secret key explicitly specified.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#ymq_secret_key YandexProvider#ymq_secret_key}
        /// </remarks>
        [JsiiProperty(name: "ymqSecretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? YmqSecretKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#zone YandexProvider#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IYandexProviderConfig), fullyQualifiedName: "yandex.provider.YandexProviderConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.Provider.IYandexProviderConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Alias name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#alias YandexProvider#alias}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alias
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ID of Yandex.Cloud tenant.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#cloud_id YandexProvider#cloud_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CloudId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The API endpoint for Yandex.Cloud SDK client.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#endpoint YandexProvider#endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Endpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The default folder ID where resources will be placed.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#folder_id YandexProvider#folder_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FolderId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Explicitly allow the provider to perform "insecure" SSL requests. If omitted,default value is `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#insecure YandexProvider#insecure}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "insecure", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Insecure
            {
                get => GetInstanceProperty<object?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#organization_id YandexProvider#organization_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OrganizationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Disable use of TLS. Default value is `false`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#plaintext YandexProvider#plaintext}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "plaintext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Plaintext
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#region_id YandexProvider#region_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RegionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Either the path to or the contents of a Service Account key file in JSON format.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#service_account_key_file YandexProvider#service_account_key_file}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAccountKeyFile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceAccountKeyFile
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Yandex.Cloud storage service access key.  Used when a storage data/resource doesn't have an access key explicitly specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#storage_access_key YandexProvider#storage_access_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageAccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Yandex.Cloud storage service endpoint. Default is  storage.yandexcloud.net.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#storage_endpoint YandexProvider#storage_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Yandex.Cloud storage service secret key.  Used when a storage data/resource doesn't have a secret key explicitly specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#storage_secret_key YandexProvider#storage_secret_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageSecretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageSecretKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The access token for API operations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#token YandexProvider#token}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Yandex.Cloud Message Queue service access key.  Used when a message queue resource doesn't have an access key explicitly specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#ymq_access_key YandexProvider#ymq_access_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ymqAccessKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? YmqAccessKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Yandex.Cloud Message Queue service endpoint. Default is  message-queue.api.cloud.yandex.net.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#ymq_endpoint YandexProvider#ymq_endpoint}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ymqEndpoint", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? YmqEndpoint
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Yandex.Cloud Message Queue service secret key.  Used when a message queue resource doesn't have a secret key explicitly specified.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#ymq_secret_key YandexProvider#ymq_secret_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ymqSecretKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? YmqSecretKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The zone where operations will take place. Examples are ru-central1-a, ru-central2-c, etc.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex#zone YandexProvider#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
