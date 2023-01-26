using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.OrganizationmanagerSamlFederation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.organizationmanagerSamlFederation.OrganizationmanagerSamlFederationSecuritySettings")]
    public class OrganizationmanagerSamlFederationSecuritySettings : yandex.OrganizationmanagerSamlFederation.IOrganizationmanagerSamlFederationSecuritySettings
    {
        private object _encryptedAssertions;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/organizationmanager_saml_federation#encrypted_assertions OrganizationmanagerSamlFederation#encrypted_assertions}.</summary>
        [JsiiProperty(name: "encryptedAssertions", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object EncryptedAssertions
        {
            get => _encryptedAssertions;
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
                _encryptedAssertions = value;
            }
        }
    }
}
