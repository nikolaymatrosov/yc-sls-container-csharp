using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionTrigger
{
    [JsiiInterface(nativeType: typeof(IFunctionTriggerLogGroup), fullyQualifiedName: "yandex.functionTrigger.FunctionTriggerLogGroup")]
    public interface IFunctionTriggerLogGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#batch_cutoff FunctionTrigger#batch_cutoff}.</summary>
        [JsiiProperty(name: "batchCutoff", typeJson: "{\"primitive\":\"string\"}")]
        string BatchCutoff
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#log_group_ids FunctionTrigger#log_group_ids}.</summary>
        [JsiiProperty(name: "logGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] LogGroupIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#batch_size FunctionTrigger#batch_size}.</summary>
        [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BatchSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionTriggerLogGroup), fullyQualifiedName: "yandex.functionTrigger.FunctionTriggerLogGroup")]
        internal sealed class _Proxy : DeputyBase, yandex.FunctionTrigger.IFunctionTriggerLogGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#batch_cutoff FunctionTrigger#batch_cutoff}.</summary>
            [JsiiProperty(name: "batchCutoff", typeJson: "{\"primitive\":\"string\"}")]
            public string BatchCutoff
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#log_group_ids FunctionTrigger#log_group_ids}.</summary>
            [JsiiProperty(name: "logGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] LogGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#batch_size FunctionTrigger#batch_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BatchSize
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
