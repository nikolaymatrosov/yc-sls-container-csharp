using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LockboxSecretVersion
{
    [JsiiInterface(nativeType: typeof(ILockboxSecretVersionEntries), fullyQualifiedName: "yandex.lockboxSecretVersion.LockboxSecretVersionEntries")]
    public interface ILockboxSecretVersionEntries
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#key LockboxSecretVersion#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>command block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#command LockboxSecretVersion#command}
        /// </remarks>
        [JsiiProperty(name: "command", typeJson: "{\"fqn\":\"yandex.lockboxSecretVersion.LockboxSecretVersionEntriesCommand\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.LockboxSecretVersion.ILockboxSecretVersionEntriesCommand? Command
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#text_value LockboxSecretVersion#text_value}.</summary>
        [JsiiProperty(name: "textValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TextValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILockboxSecretVersionEntries), fullyQualifiedName: "yandex.lockboxSecretVersion.LockboxSecretVersionEntries")]
        internal sealed class _Proxy : DeputyBase, yandex.LockboxSecretVersion.ILockboxSecretVersionEntries
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#key LockboxSecretVersion#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>command block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#command LockboxSecretVersion#command}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "command", typeJson: "{\"fqn\":\"yandex.lockboxSecretVersion.LockboxSecretVersionEntriesCommand\"}", isOptional: true)]
            public yandex.LockboxSecretVersion.ILockboxSecretVersionEntriesCommand? Command
            {
                get => GetInstanceProperty<yandex.LockboxSecretVersion.ILockboxSecretVersionEntriesCommand?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#text_value LockboxSecretVersion#text_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "textValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TextValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
