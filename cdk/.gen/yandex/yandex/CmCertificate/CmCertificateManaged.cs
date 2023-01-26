using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.CmCertificate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.cmCertificate.CmCertificateManaged")]
    public class CmCertificateManaged : yandex.CmCertificate.ICmCertificateManaged
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#challenge_type CmCertificate#challenge_type}.</summary>
        [JsiiProperty(name: "challengeType", typeJson: "{\"primitive\":\"string\"}")]
        public string ChallengeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#challenge_count CmCertificate#challenge_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "challengeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ChallengeCount
        {
            get;
            set;
        }
    }
}
