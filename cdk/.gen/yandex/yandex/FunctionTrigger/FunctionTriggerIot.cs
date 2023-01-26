using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.functionTrigger.FunctionTriggerIot")]
    public class FunctionTriggerIot : yandex.FunctionTrigger.IFunctionTriggerIot
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#registry_id FunctionTrigger#registry_id}.</summary>
        [JsiiProperty(name: "registryId", typeJson: "{\"primitive\":\"string\"}")]
        public string RegistryId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#device_id FunctionTrigger#device_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeviceId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#topic FunctionTrigger#topic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "topic", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Topic
        {
            get;
            set;
        }
    }
}
