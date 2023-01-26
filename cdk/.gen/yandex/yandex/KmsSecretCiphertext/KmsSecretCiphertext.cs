using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KmsSecretCiphertext
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/kms_secret_ciphertext yandex_kms_secret_ciphertext}.</summary>
    [JsiiClass(nativeType: typeof(yandex.KmsSecretCiphertext.KmsSecretCiphertext), fullyQualifiedName: "yandex.kmsSecretCiphertext.KmsSecretCiphertext", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.kmsSecretCiphertext.KmsSecretCiphertextConfig\"}}]")]
    public class KmsSecretCiphertext : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/kms_secret_ciphertext yandex_kms_secret_ciphertext} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public KmsSecretCiphertext(Constructs.Construct scope, string id, yandex.KmsSecretCiphertext.IKmsSecretCiphertextConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.KmsSecretCiphertext.IKmsSecretCiphertextConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsSecretCiphertext(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KmsSecretCiphertext(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kmsSecretCiphertext.KmsSecretCiphertextTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.KmsSecretCiphertext.IKmsSecretCiphertextTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KmsSecretCiphertext.IKmsSecretCiphertextTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAadContext")]
        public virtual void ResetAadContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(yandex.KmsSecretCiphertext.KmsSecretCiphertext))!;

        [JsiiProperty(name: "ciphertext", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ciphertext
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.kmsSecretCiphertext.KmsSecretCiphertextTimeoutsOutputReference\"}")]
        public virtual yandex.KmsSecretCiphertext.KmsSecretCiphertextTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.KmsSecretCiphertext.KmsSecretCiphertextTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aadContextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AadContextInput
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
        [JsiiProperty(name: "keyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "plaintextInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlaintextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.kmsSecretCiphertext.KmsSecretCiphertextTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "aadContext", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AadContext
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

        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "plaintext", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Plaintext
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
