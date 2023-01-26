using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.CmCertificate
{
    [JsiiInterface(nativeType: typeof(ICmCertificateManaged), fullyQualifiedName: "yandex.cmCertificate.CmCertificateManaged")]
    public interface ICmCertificateManaged
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#challenge_type CmCertificate#challenge_type}.</summary>
        [JsiiProperty(name: "challengeType", typeJson: "{\"primitive\":\"string\"}")]
        string ChallengeType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#challenge_count CmCertificate#challenge_count}.</summary>
        [JsiiProperty(name: "challengeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ChallengeCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICmCertificateManaged), fullyQualifiedName: "yandex.cmCertificate.CmCertificateManaged")]
        internal sealed class _Proxy : DeputyBase, yandex.CmCertificate.ICmCertificateManaged
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#challenge_type CmCertificate#challenge_type}.</summary>
            [JsiiProperty(name: "challengeType", typeJson: "{\"primitive\":\"string\"}")]
            public string ChallengeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#challenge_count CmCertificate#challenge_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "challengeCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ChallengeCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
