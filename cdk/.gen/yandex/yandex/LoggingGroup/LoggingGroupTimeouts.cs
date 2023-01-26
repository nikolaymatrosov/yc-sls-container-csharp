using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LoggingGroup
{
    [JsiiByValue(fqn: "yandex.loggingGroup.LoggingGroupTimeouts")]
    public class LoggingGroupTimeouts : yandex.LoggingGroup.ILoggingGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/logging_group#default LoggingGroup#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}
