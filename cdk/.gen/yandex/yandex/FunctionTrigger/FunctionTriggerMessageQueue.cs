using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.functionTrigger.FunctionTriggerMessageQueue")]
    public class FunctionTriggerMessageQueue : yandex.FunctionTrigger.IFunctionTriggerMessageQueue
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#batch_cutoff FunctionTrigger#batch_cutoff}.</summary>
        [JsiiProperty(name: "batchCutoff", typeJson: "{\"primitive\":\"string\"}")]
        public string BatchCutoff
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#queue_id FunctionTrigger#queue_id}.</summary>
        [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}")]
        public string QueueId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#service_account_id FunctionTrigger#service_account_id}.</summary>
        [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceAccountId
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#visibility_timeout FunctionTrigger#visibility_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "visibilityTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VisibilityTimeout
        {
            get;
            set;
        }
    }
}
