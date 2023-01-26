using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.functionTrigger.FunctionTriggerLogGroup")]
    public class FunctionTriggerLogGroup : yandex.FunctionTrigger.IFunctionTriggerLogGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#batch_cutoff FunctionTrigger#batch_cutoff}.</summary>
        [JsiiProperty(name: "batchCutoff", typeJson: "{\"primitive\":\"string\"}")]
        public string BatchCutoff
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#log_group_ids FunctionTrigger#log_group_ids}.</summary>
        [JsiiProperty(name: "logGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] LogGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#batch_size FunctionTrigger#batch_size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? BatchSize
        {
            get;
            set;
        }
    }
}
