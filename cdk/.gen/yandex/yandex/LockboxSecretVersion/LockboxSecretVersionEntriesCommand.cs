using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LockboxSecretVersion
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.lockboxSecretVersion.LockboxSecretVersionEntriesCommand")]
    public class LockboxSecretVersionEntriesCommand : yandex.LockboxSecretVersion.ILockboxSecretVersionEntriesCommand
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#path LockboxSecretVersion#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#args LockboxSecretVersion#args}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Args
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lockbox_secret_version#env LockboxSecretVersion#env}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Env
        {
            get;
            set;
        }
    }
}
