using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionTrigger
{
    [JsiiInterface(nativeType: typeof(IFunctionTriggerDlq), fullyQualifiedName: "yandex.functionTrigger.FunctionTriggerDlq")]
    public interface IFunctionTriggerDlq
    {
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

        [JsiiTypeProxy(nativeType: typeof(IFunctionTriggerDlq), fullyQualifiedName: "yandex.functionTrigger.FunctionTriggerDlq")]
        internal sealed class _Proxy : DeputyBase, yandex.FunctionTrigger.IFunctionTriggerDlq
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
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
        }
    }
}
