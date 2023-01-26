using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.CmCertificate
{
    [JsiiInterface(nativeType: typeof(ICmCertificateSelfManaged), fullyQualifiedName: "yandex.cmCertificate.CmCertificateSelfManaged")]
    public interface ICmCertificateSelfManaged
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#certificate CmCertificate#certificate}.</summary>
        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        string Certificate
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#private_key CmCertificate#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_key_lockbox_secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#private_key_lockbox_secret CmCertificate#private_key_lockbox_secret}
        /// </remarks>
        [JsiiProperty(name: "privateKeyLockboxSecret", typeJson: "{\"fqn\":\"yandex.cmCertificate.CmCertificateSelfManagedPrivateKeyLockboxSecret\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.CmCertificate.ICmCertificateSelfManagedPrivateKeyLockboxSecret? PrivateKeyLockboxSecret
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICmCertificateSelfManaged), fullyQualifiedName: "yandex.cmCertificate.CmCertificateSelfManaged")]
        internal sealed class _Proxy : DeputyBase, yandex.CmCertificate.ICmCertificateSelfManaged
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#certificate CmCertificate#certificate}.</summary>
            [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
            public string Certificate
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#private_key CmCertificate#private_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>private_key_lockbox_secret block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/cm_certificate#private_key_lockbox_secret CmCertificate#private_key_lockbox_secret}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateKeyLockboxSecret", typeJson: "{\"fqn\":\"yandex.cmCertificate.CmCertificateSelfManagedPrivateKeyLockboxSecret\"}", isOptional: true)]
            public yandex.CmCertificate.ICmCertificateSelfManagedPrivateKeyLockboxSecret? PrivateKeyLockboxSecret
            {
                get => GetInstanceProperty<yandex.CmCertificate.ICmCertificateSelfManagedPrivateKeyLockboxSecret?>();
            }
        }
    }
}
