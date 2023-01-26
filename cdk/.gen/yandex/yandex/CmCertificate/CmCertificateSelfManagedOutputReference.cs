using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.CmCertificate
{
    [JsiiClass(nativeType: typeof(yandex.CmCertificate.CmCertificateSelfManagedOutputReference), fullyQualifiedName: "yandex.cmCertificate.CmCertificateSelfManagedOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CmCertificateSelfManagedOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CmCertificateSelfManagedOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CmCertificateSelfManagedOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CmCertificateSelfManagedOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPrivateKeyLockboxSecret", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.cmCertificate.CmCertificateSelfManagedPrivateKeyLockboxSecret\"}}]")]
        public virtual void PutPrivateKeyLockboxSecret(yandex.CmCertificate.ICmCertificateSelfManagedPrivateKeyLockboxSecret @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.CmCertificate.ICmCertificateSelfManagedPrivateKeyLockboxSecret)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPrivateKey")]
        public virtual void ResetPrivateKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateKeyLockboxSecret")]
        public virtual void ResetPrivateKeyLockboxSecret()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "privateKeyLockboxSecret", typeJson: "{\"fqn\":\"yandex.cmCertificate.CmCertificateSelfManagedPrivateKeyLockboxSecretOutputReference\"}")]
        public virtual yandex.CmCertificate.CmCertificateSelfManagedPrivateKeyLockboxSecretOutputReference PrivateKeyLockboxSecret
        {
            get => GetInstanceProperty<yandex.CmCertificate.CmCertificateSelfManagedPrivateKeyLockboxSecretOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateKeyLockboxSecretInput", typeJson: "{\"fqn\":\"yandex.cmCertificate.CmCertificateSelfManagedPrivateKeyLockboxSecret\"}", isOptional: true)]
        public virtual yandex.CmCertificate.ICmCertificateSelfManagedPrivateKeyLockboxSecret? PrivateKeyLockboxSecretInput
        {
            get => GetInstanceProperty<yandex.CmCertificate.ICmCertificateSelfManagedPrivateKeyLockboxSecret?>();
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Certificate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.cmCertificate.CmCertificateSelfManaged\"}", isOptional: true)]
        public virtual yandex.CmCertificate.ICmCertificateSelfManaged? InternalValue
        {
            get => GetInstanceProperty<yandex.CmCertificate.ICmCertificateSelfManaged?>();
            set => SetInstanceProperty(value);
        }
    }
}
