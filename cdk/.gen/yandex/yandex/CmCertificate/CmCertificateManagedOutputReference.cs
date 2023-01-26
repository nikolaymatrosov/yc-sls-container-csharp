using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.CmCertificate
{
    [JsiiClass(nativeType: typeof(yandex.CmCertificate.CmCertificateManagedOutputReference), fullyQualifiedName: "yandex.cmCertificate.CmCertificateManagedOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CmCertificateManagedOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CmCertificateManagedOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CmCertificateManagedOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CmCertificateManagedOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetChallengeCount")]
        public virtual void ResetChallengeCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "challengeCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ChallengeCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "challengeTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ChallengeTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "challengeCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ChallengeCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "challengeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ChallengeType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.cmCertificate.CmCertificateManaged\"}", isOptional: true)]
        public virtual yandex.CmCertificate.ICmCertificateManaged? InternalValue
        {
            get => GetInstanceProperty<yandex.CmCertificate.ICmCertificateManaged?>();
            set => SetInstanceProperty(value);
        }
    }
}
