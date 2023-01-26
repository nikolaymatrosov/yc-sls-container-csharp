using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionTrigger
{
    [JsiiInterface(nativeType: typeof(IFunctionTriggerMessageQueue), fullyQualifiedName: "yandex.functionTrigger.FunctionTriggerMessageQueue")]
    public interface IFunctionTriggerMessageQueue
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#batch_cutoff FunctionTrigger#batch_cutoff}.</summary>
        [JsiiProperty(name: "batchCutoff", typeJson: "{\"primitive\":\"string\"}")]
        string BatchCutoff
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#queue_id FunctionTrigger#queue_id}.</summary>
        [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}")]
        string QueueId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#service_account_id FunctionTrigger#service_account_id}.</summary>
        [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        string ServiceAccountId
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#visibility_timeout FunctionTrigger#visibility_timeout}.</summary>
        [JsiiProperty(name: "visibilityTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VisibilityTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionTriggerMessageQueue), fullyQualifiedName: "yandex.functionTrigger.FunctionTriggerMessageQueue")]
        internal sealed class _Proxy : DeputyBase, yandex.FunctionTrigger.IFunctionTriggerMessageQueue
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

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#queue_id FunctionTrigger#queue_id}.</summary>
            [JsiiProperty(name: "queueId", typeJson: "{\"primitive\":\"string\"}")]
            public string QueueId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#service_account_id FunctionTrigger#service_account_id}.</summary>
            [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
            public string ServiceAccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#batch_size FunctionTrigger#batch_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "batchSize", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BatchSize
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#visibility_timeout FunctionTrigger#visibility_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "visibilityTimeout", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VisibilityTimeout
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
