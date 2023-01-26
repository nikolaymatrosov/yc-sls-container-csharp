using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.OrganizationmanagerSamlFederation
{
    [JsiiInterface(nativeType: typeof(IOrganizationmanagerSamlFederationConfig), fullyQualifiedName: "yandex.organizationmanagerSamlFederation.OrganizationmanagerSamlFederationConfig")]
    public interface IOrganizationmanagerSamlFederationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#issuer OrganizationmanagerSamlFederation#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        string Issuer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#name OrganizationmanagerSamlFederation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#organization_id OrganizationmanagerSamlFederation#organization_id}.</summary>
        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        string OrganizationId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#sso_binding OrganizationmanagerSamlFederation#sso_binding}.</summary>
        [JsiiProperty(name: "ssoBinding", typeJson: "{\"primitive\":\"string\"}")]
        string SsoBinding
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#sso_url OrganizationmanagerSamlFederation#sso_url}.</summary>
        [JsiiProperty(name: "ssoUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SsoUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#auto_create_account_on_login OrganizationmanagerSamlFederation#auto_create_account_on_login}.</summary>
        [JsiiProperty(name: "autoCreateAccountOnLogin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AutoCreateAccountOnLogin
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#case_insensitive_name_ids OrganizationmanagerSamlFederation#case_insensitive_name_ids}.</summary>
        [JsiiProperty(name: "caseInsensitiveNameIds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CaseInsensitiveNameIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#cookie_max_age OrganizationmanagerSamlFederation#cookie_max_age}.</summary>
        [JsiiProperty(name: "cookieMaxAge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CookieMaxAge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#description OrganizationmanagerSamlFederation#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#id OrganizationmanagerSamlFederation#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#labels OrganizationmanagerSamlFederation#labels}.</summary>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>security_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#security_settings OrganizationmanagerSamlFederation#security_settings}
        /// </remarks>
        [JsiiProperty(name: "securitySettings", typeJson: "{\"fqn\":\"yandex.organizationmanagerSamlFederation.OrganizationmanagerSamlFederationSecuritySettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.OrganizationmanagerSamlFederation.IOrganizationmanagerSamlFederationSecuritySettings? SecuritySettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#timeouts OrganizationmanagerSamlFederation#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.organizationmanagerSamlFederation.OrganizationmanagerSamlFederationTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.OrganizationmanagerSamlFederation.IOrganizationmanagerSamlFederationTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOrganizationmanagerSamlFederationConfig), fullyQualifiedName: "yandex.organizationmanagerSamlFederation.OrganizationmanagerSamlFederationConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.OrganizationmanagerSamlFederation.IOrganizationmanagerSamlFederationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#issuer OrganizationmanagerSamlFederation#issuer}.</summary>
            [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
            public string Issuer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#name OrganizationmanagerSamlFederation#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#organization_id OrganizationmanagerSamlFederation#organization_id}.</summary>
            [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
            public string OrganizationId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#sso_binding OrganizationmanagerSamlFederation#sso_binding}.</summary>
            [JsiiProperty(name: "ssoBinding", typeJson: "{\"primitive\":\"string\"}")]
            public string SsoBinding
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#sso_url OrganizationmanagerSamlFederation#sso_url}.</summary>
            [JsiiProperty(name: "ssoUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SsoUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#auto_create_account_on_login OrganizationmanagerSamlFederation#auto_create_account_on_login}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoCreateAccountOnLogin", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AutoCreateAccountOnLogin
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#case_insensitive_name_ids OrganizationmanagerSamlFederation#case_insensitive_name_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "caseInsensitiveNameIds", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CaseInsensitiveNameIds
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#cookie_max_age OrganizationmanagerSamlFederation#cookie_max_age}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cookieMaxAge", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CookieMaxAge
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#description OrganizationmanagerSamlFederation#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#id OrganizationmanagerSamlFederation#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#labels OrganizationmanagerSamlFederation#labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Labels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>security_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#security_settings OrganizationmanagerSamlFederation#security_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "securitySettings", typeJson: "{\"fqn\":\"yandex.organizationmanagerSamlFederation.OrganizationmanagerSamlFederationSecuritySettings\"}", isOptional: true)]
            public yandex.OrganizationmanagerSamlFederation.IOrganizationmanagerSamlFederationSecuritySettings? SecuritySettings
            {
                get => GetInstanceProperty<yandex.OrganizationmanagerSamlFederation.IOrganizationmanagerSamlFederationSecuritySettings?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#timeouts OrganizationmanagerSamlFederation#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.organizationmanagerSamlFederation.OrganizationmanagerSamlFederationTimeouts\"}", isOptional: true)]
            public yandex.OrganizationmanagerSamlFederation.IOrganizationmanagerSamlFederationTimeouts? Timeouts
            {
                get => GetInstanceProperty<yandex.OrganizationmanagerSamlFederation.IOrganizationmanagerSamlFederationTimeouts?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
