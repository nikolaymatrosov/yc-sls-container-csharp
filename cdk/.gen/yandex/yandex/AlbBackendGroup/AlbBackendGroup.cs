using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group yandex_alb_backend_group}.</summary>
    [JsiiClass(nativeType: typeof(yandex.AlbBackendGroup.AlbBackendGroup), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupConfig\"}}]")]
    public class AlbBackendGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group yandex_alb_backend_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AlbBackendGroup(Constructs.Construct scope, string id, yandex.AlbBackendGroup.IAlbBackendGroupConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.AlbBackendGroup.IAlbBackendGroupConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbBackendGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbBackendGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpcBackend", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackend\"},\"kind\":\"array\"}},{\"fqn\":\"cdktf.IResolvable\"}]}}}]")]
        public virtual void PutGrpcBackend(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackend[] cast_2ed7d7:
                        break;
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackend).FullName}[], {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackend).FullName}[], {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpBackend", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackend\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHttpBackend(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.AlbBackendGroup.IAlbBackendGroupHttpBackend[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbBackendGroup.IAlbBackendGroupHttpBackend).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbBackendGroup.IAlbBackendGroupHttpBackend).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSessionAffinity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinity\"}}]")]
        public virtual void PutSessionAffinity(yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStreamBackend", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackend\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStreamBackend(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.AlbBackendGroup.IAlbBackendGroupStreamBackend[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbBackendGroup.IAlbBackendGroupStreamBackend).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbBackendGroup.IAlbBackendGroupStreamBackend).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.AlbBackendGroup.IAlbBackendGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFolderId")]
        public virtual void ResetFolderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrpcBackend")]
        public virtual void ResetGrpcBackend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpBackend")]
        public virtual void ResetHttpBackend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionAffinity")]
        public virtual void ResetSessionAffinity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStreamBackend")]
        public virtual void ResetStreamBackend()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(yandex.AlbBackendGroup.AlbBackendGroup))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grpcBackend", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendList\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendList GrpcBackend
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupGrpcBackendList>()!;
        }

        [JsiiProperty(name: "httpBackend", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackendList\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupHttpBackendList HttpBackend
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupHttpBackendList>()!;
        }

        [JsiiProperty(name: "sessionAffinity", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupSessionAffinityOutputReference SessionAffinity
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupSessionAffinityOutputReference>()!;
        }

        [JsiiProperty(name: "streamBackend", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendList\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupStreamBackendList StreamBackend
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupStreamBackendList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupTimeoutsOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
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
        [JsiiProperty(name: "grpcBackendInput", typeJson: "{\"union\":{\"types\":[{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackend\"},\"kind\":\"array\"}},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? GrpcBackendInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpBackendInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupHttpBackend\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HttpBackendInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionAffinityInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinity\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinity? SessionAffinityInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "streamBackendInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackend\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StreamBackendInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
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

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
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
