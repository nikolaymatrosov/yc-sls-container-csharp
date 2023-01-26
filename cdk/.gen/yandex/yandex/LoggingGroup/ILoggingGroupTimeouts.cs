using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LoggingGroup
{
    [JsiiInterface(nativeType: typeof(ILoggingGroupTimeouts), fullyQualifiedName: "yandex.loggingGroup.LoggingGroupTimeouts")]
    public interface ILoggingGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/logging_group#default LoggingGroup#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoggingGroupTimeouts), fullyQualifiedName: "yandex.loggingGroup.LoggingGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, yandex.LoggingGroup.ILoggingGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/logging_group#default LoggingGroup#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
