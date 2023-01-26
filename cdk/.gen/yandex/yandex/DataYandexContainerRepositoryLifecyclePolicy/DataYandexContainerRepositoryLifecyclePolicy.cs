using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexContainerRepositoryLifecyclePolicy
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/container_repository_lifecycle_policy yandex_container_repository_lifecycle_policy}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicy), fullyQualifiedName: "yandex.dataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.dataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyConfig\"}}]")]
    public class DataYandexContainerRepositoryLifecyclePolicy : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/container_repository_lifecycle_policy yandex_container_repository_lifecycle_policy} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexContainerRepositoryLifecyclePolicy(Constructs.Construct scope, string id, yandex.DataYandexContainerRepositoryLifecyclePolicy.IDataYandexContainerRepositoryLifecyclePolicyConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexContainerRepositoryLifecyclePolicy.IDataYandexContainerRepositoryLifecyclePolicyConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexContainerRepositoryLifecyclePolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexContainerRepositoryLifecyclePolicy(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.DataYandexContainerRepositoryLifecyclePolicy.IDataYandexContainerRepositoryLifecyclePolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexContainerRepositoryLifecyclePolicy.IDataYandexContainerRepositoryLifecyclePolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecyclePolicyId")]
        public virtual void ResetLifecyclePolicyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepositoryId")]
        public virtual void ResetRepositoryId()
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
        = GetStaticProperty<string>(typeof(yandex.DataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicy))!;

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

        [JsiiProperty(name: "rule", typeJson: "{\"fqn\":\"yandex.dataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyRuleList\"}")]
        public virtual yandex.DataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyRuleList Rule
        {
            get => GetInstanceProperty<yandex.DataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyRuleList>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.dataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyTimeoutsOutputReference\"}")]
        public virtual yandex.DataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.DataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecyclePolicyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LifecyclePolicyIdInput
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
        [JsiiProperty(name: "repositoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RepositoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.dataYandexContainerRepositoryLifecyclePolicy.DataYandexContainerRepositoryLifecyclePolicyTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lifecyclePolicyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecyclePolicyId
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

        [JsiiProperty(name: "repositoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RepositoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
