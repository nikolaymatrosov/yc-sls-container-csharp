using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LockboxSecretVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.lockboxSecretVersion.LockboxSecretVersionEntries")]
    public class LockboxSecretVersionEntries : yandex.LockboxSecretVersion.ILockboxSecretVersionEntries
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#key LockboxSecretVersion#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>command block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#command LockboxSecretVersion#command}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "command", typeJson: "{\"fqn\":\"yandex.lockboxSecretVersion.LockboxSecretVersionEntriesCommand\"}", isOptional: true)]
        public yandex.LockboxSecretVersion.ILockboxSecretVersionEntriesCommand? Command
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#text_value LockboxSecretVersion#text_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "textValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TextValue
        {
            get;
            set;
        }
    }
}
