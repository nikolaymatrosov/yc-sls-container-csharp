using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.OrganizationmanagerSamlFederation
{
    [JsiiInterface(nativeType: typeof(IOrganizationmanagerSamlFederationSecuritySettings), fullyQualifiedName: "yandex.organizationmanagerSamlFederation.OrganizationmanagerSamlFederationSecuritySettings")]
    public interface IOrganizationmanagerSamlFederationSecuritySettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#encrypted_assertions OrganizationmanagerSamlFederation#encrypted_assertions}.</summary>
        [JsiiProperty(name: "encryptedAssertions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object EncryptedAssertions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOrganizationmanagerSamlFederationSecuritySettings), fullyQualifiedName: "yandex.organizationmanagerSamlFederation.OrganizationmanagerSamlFederationSecuritySettings")]
        internal sealed class _Proxy : DeputyBase, yandex.OrganizationmanagerSamlFederation.IOrganizationmanagerSamlFederationSecuritySettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#encrypted_assertions OrganizationmanagerSamlFederation#encrypted_assertions}.</summary>
            [JsiiProperty(name: "encryptedAssertions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object EncryptedAssertions
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
