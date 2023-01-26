using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexServerlessContainer
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/serverless_container yandex_serverless_container}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexServerlessContainer.DataYandexServerlessContainer), fullyQualifiedName: "yandex.dataYandexServerlessContainer.DataYandexServerlessContainer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.dataYandexServerlessContainer.DataYandexServerlessContainerConfig\"}}]")]
    public class DataYandexServerlessContainer : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/serverless_container yandex_serverless_container} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexServerlessContainer(Constructs.Construct scope, string id, yandex.DataYandexServerlessContainer.IDataYandexServerlessContainerConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexServerlessContainer.IDataYandexServerlessContainerConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexServerlessContainer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexServerlessContainer(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSecrets", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexServerlessContainer.DataYandexServerlessContainerSecrets\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecrets(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.DataYandexServerlessContainer.IDataYandexServerlessContainerSecrets[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataYandexServerlessContainer.IDataYandexServerlessContainerSecrets).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataYandexServerlessContainer.IDataYandexServerlessContainerSecrets).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContainerId")]
        public virtual void ResetContainerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFolderId")]
        public virtual void ResetFolderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecrets")]
        public virtual void ResetSecrets()
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
        = GetStaticProperty<string>(typeof(yandex.DataYandexServerlessContainer.DataYandexServerlessContainer))!;

        [JsiiProperty(name: "concurrency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Concurrency
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "coreFraction", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CoreFraction
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "cores", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cores
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "executionTimeout", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionTimeout
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "image", typeJson: "{\"fqn\":\"yandex.dataYandexServerlessContainer.DataYandexServerlessContainerImageList\"}")]
        public virtual yandex.DataYandexServerlessContainer.DataYandexServerlessContainerImageList Image
        {
            get => GetInstanceProperty<yandex.DataYandexServerlessContainer.DataYandexServerlessContainerImageList>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Memory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "revisionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevisionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secrets", typeJson: "{\"fqn\":\"yandex.dataYandexServerlessContainer.DataYandexServerlessContainerSecretsList\"}")]
        public virtual yandex.DataYandexServerlessContainer.DataYandexServerlessContainerSecretsList Secrets
        {
            get => GetInstanceProperty<yandex.DataYandexServerlessContainer.DataYandexServerlessContainerSecretsList>()!;
        }

        [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Url
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerIdInput
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexServerlessContainer.DataYandexServerlessContainerSecrets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecretsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "containerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerId
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
