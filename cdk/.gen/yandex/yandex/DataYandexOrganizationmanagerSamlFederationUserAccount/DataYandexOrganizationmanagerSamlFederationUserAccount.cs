using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexOrganizationmanagerSamlFederationUserAccount
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/organizationmanager_saml_federation_user_account yandex_organizationmanager_saml_federation_user_account}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexOrganizationmanagerSamlFederationUserAccount.DataYandexOrganizationmanagerSamlFederationUserAccount), fullyQualifiedName: "yandex.dataYandexOrganizationmanagerSamlFederationUserAccount.DataYandexOrganizationmanagerSamlFederationUserAccount", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.dataYandexOrganizationmanagerSamlFederationUserAccount.DataYandexOrganizationmanagerSamlFederationUserAccountConfig\"}}]")]
    public class DataYandexOrganizationmanagerSamlFederationUserAccount : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/organizationmanager_saml_federation_user_account yandex_organizationmanager_saml_federation_user_account} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexOrganizationmanagerSamlFederationUserAccount(Constructs.Construct scope, string id, yandex.DataYandexOrganizationmanagerSamlFederationUserAccount.IDataYandexOrganizationmanagerSamlFederationUserAccountConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexOrganizationmanagerSamlFederationUserAccount.IDataYandexOrganizationmanagerSamlFederationUserAccountConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexOrganizationmanagerSamlFederationUserAccount(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexOrganizationmanagerSamlFederationUserAccount(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(yandex.DataYandexOrganizationmanagerSamlFederationUserAccount.DataYandexOrganizationmanagerSamlFederationUserAccount))!;

        [JsiiOptional]
        [JsiiProperty(name: "federationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FederationIdInput
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
        [JsiiProperty(name: "nameIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "federationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FederationId
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

        [JsiiProperty(name: "nameId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
