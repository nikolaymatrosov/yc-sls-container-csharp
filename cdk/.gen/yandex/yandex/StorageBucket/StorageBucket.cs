using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.StorageBucket
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket yandex_storage_bucket}.</summary>
    [JsiiClass(nativeType: typeof(yandex.StorageBucket.StorageBucket), fullyQualifiedName: "yandex.storageBucket.StorageBucket", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.storageBucket.StorageBucketConfig\"}}]")]
    public class StorageBucket : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/storage_bucket yandex_storage_bucket} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public StorageBucket(Constructs.Construct scope, string id, yandex.StorageBucket.IStorageBucketConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.StorageBucket.IStorageBucketConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageBucket(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected StorageBucket(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAnonymousAccessFlags", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.storageBucket.StorageBucketAnonymousAccessFlags\"}}]")]
        public virtual void PutAnonymousAccessFlags(yandex.StorageBucket.IStorageBucketAnonymousAccessFlags @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.StorageBucket.IStorageBucketAnonymousAccessFlags)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCorsRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketCorsRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCorsRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.StorageBucket.IStorageBucketCorsRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketCorsRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketCorsRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrant", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketGrant\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGrant(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.StorageBucket.IStorageBucketGrant[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketGrant).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketGrant).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttps", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.storageBucket.StorageBucketHttps\"}}]")]
        public virtual void PutHttps(yandex.StorageBucket.IStorageBucketHttps @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.StorageBucket.IStorageBucketHttps)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLifecycleRule", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRule\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLifecycleRule(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.StorageBucket.IStorageBucketLifecycleRule[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketLifecycleRule).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketLifecycleRule).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogging", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketLogging\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLogging(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.StorageBucket.IStorageBucketLogging[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketLogging).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.StorageBucket.IStorageBucketLogging).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServerSideEncryptionConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfiguration\"}}]")]
        public virtual void PutServerSideEncryptionConfiguration(yandex.StorageBucket.IStorageBucketServerSideEncryptionConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.StorageBucket.IStorageBucketServerSideEncryptionConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVersioning", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.storageBucket.StorageBucketVersioning\"}}]")]
        public virtual void PutVersioning(yandex.StorageBucket.IStorageBucketVersioning @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.StorageBucket.IStorageBucketVersioning)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebsite", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.storageBucket.StorageBucketWebsite\"}}]")]
        public virtual void PutWebsite(yandex.StorageBucket.IStorageBucketWebsite @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.StorageBucket.IStorageBucketWebsite)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessKey")]
        public virtual void ResetAccessKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAcl")]
        public virtual void ResetAcl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAnonymousAccessFlags")]
        public virtual void ResetAnonymousAccessFlags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucket")]
        public virtual void ResetBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBucketPrefix")]
        public virtual void ResetBucketPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCorsRule")]
        public virtual void ResetCorsRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultStorageClass")]
        public virtual void ResetDefaultStorageClass()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFolderId")]
        public virtual void ResetFolderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetForceDestroy")]
        public virtual void ResetForceDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrant")]
        public virtual void ResetGrant()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttps")]
        public virtual void ResetHttps()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecycleRule")]
        public virtual void ResetLifecycleRule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxSize")]
        public virtual void ResetMaxSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPolicy")]
        public virtual void ResetPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretKey")]
        public virtual void ResetSecretKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServerSideEncryptionConfiguration")]
        public virtual void ResetServerSideEncryptionConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersioning")]
        public virtual void ResetVersioning()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebsite")]
        public virtual void ResetWebsite()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebsiteDomain")]
        public virtual void ResetWebsiteDomain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebsiteEndpoint")]
        public virtual void ResetWebsiteEndpoint()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(yandex.StorageBucket.StorageBucket))!;

        [JsiiProperty(name: "anonymousAccessFlags", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketAnonymousAccessFlagsOutputReference\"}")]
        public virtual yandex.StorageBucket.StorageBucketAnonymousAccessFlagsOutputReference AnonymousAccessFlags
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketAnonymousAccessFlagsOutputReference>()!;
        }

        [JsiiProperty(name: "bucketDomainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketDomainName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "corsRule", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketCorsRuleList\"}")]
        public virtual yandex.StorageBucket.StorageBucketCorsRuleList CorsRule
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketCorsRuleList>()!;
        }

        [JsiiProperty(name: "grant", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketGrantList\"}")]
        public virtual yandex.StorageBucket.StorageBucketGrantList Grant
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketGrantList>()!;
        }

        [JsiiProperty(name: "https", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketHttpsOutputReference\"}")]
        public virtual yandex.StorageBucket.StorageBucketHttpsOutputReference Https
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketHttpsOutputReference>()!;
        }

        [JsiiProperty(name: "lifecycleRule", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRuleList\"}")]
        public virtual yandex.StorageBucket.StorageBucketLifecycleRuleList LifecycleRule
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketLifecycleRuleList>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketLoggingList\"}")]
        public virtual yandex.StorageBucket.StorageBucketLoggingList Logging
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketLoggingList>()!;
        }

        [JsiiProperty(name: "serverSideEncryptionConfiguration", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfigurationOutputReference\"}")]
        public virtual yandex.StorageBucket.StorageBucketServerSideEncryptionConfigurationOutputReference ServerSideEncryptionConfiguration
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketServerSideEncryptionConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "versioning", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketVersioningOutputReference\"}")]
        public virtual yandex.StorageBucket.StorageBucketVersioningOutputReference Versioning
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketVersioningOutputReference>()!;
        }

        [JsiiProperty(name: "website", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketWebsiteOutputReference\"}")]
        public virtual yandex.StorageBucket.StorageBucketWebsiteOutputReference Website
        {
            get => GetInstanceProperty<yandex.StorageBucket.StorageBucketWebsiteOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccessKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aclInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AclInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "anonymousAccessFlagsInput", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketAnonymousAccessFlags\"}", isOptional: true)]
        public virtual yandex.StorageBucket.IStorageBucketAnonymousAccessFlags? AnonymousAccessFlagsInput
        {
            get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketAnonymousAccessFlags?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "corsRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketCorsRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CorsRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultStorageClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultStorageClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "folderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FolderIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forceDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForceDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grantInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketGrant\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GrantInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpsInput", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketHttps\"}", isOptional: true)]
        public virtual yandex.StorageBucket.IStorageBucketHttps? HttpsInput
        {
            get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketHttps?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleRuleInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketLifecycleRule\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LifecycleRuleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.storageBucket.StorageBucketLogging\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LoggingInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "policyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PolicyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverSideEncryptionConfigurationInput", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketServerSideEncryptionConfiguration\"}", isOptional: true)]
        public virtual yandex.StorageBucket.IStorageBucketServerSideEncryptionConfiguration? ServerSideEncryptionConfigurationInput
        {
            get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketServerSideEncryptionConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versioningInput", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketVersioning\"}", isOptional: true)]
        public virtual yandex.StorageBucket.IStorageBucketVersioning? VersioningInput
        {
            get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketVersioning?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteDomainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebsiteDomainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? WebsiteEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "websiteInput", typeJson: "{\"fqn\":\"yandex.storageBucket.StorageBucketWebsite\"}", isOptional: true)]
        public virtual yandex.StorageBucket.IStorageBucketWebsite? WebsiteInput
        {
            get => GetInstanceProperty<yandex.StorageBucket.IStorageBucketWebsite?>();
        }

        [JsiiProperty(name: "accessKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "acl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Acl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Bucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultStorageClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultStorageClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FolderId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "forceDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForceDestroy
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Policy
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "websiteDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteDomain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "websiteEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WebsiteEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
