using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.CmCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.cmCertificate.CmCertificateSelfManaged")]
    public class CmCertificateSelfManaged : yandex.CmCertificate.ICmCertificateSelfManaged
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#certificate CmCertificate#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public string Certificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#private_key CmCertificate#private_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateKey
        {
            get;
            set;
        }

        /// <summary>private_key_lockbox_secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#private_key_lockbox_secret CmCertificate#private_key_lockbox_secret}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "privateKeyLockboxSecret", typeJson: "{\"fqn\":\"yandex.cmCertificate.CmCertificateSelfManagedPrivateKeyLockboxSecret\"}", isOptional: true)]
        public yandex.CmCertificate.ICmCertificateSelfManagedPrivateKeyLockboxSecret? PrivateKeyLockboxSecret
        {
            get;
            set;
        }
    }
}
