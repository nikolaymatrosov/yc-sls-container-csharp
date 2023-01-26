using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionTrigger
{
    [JsiiInterface(nativeType: typeof(IFunctionTriggerTimer), fullyQualifiedName: "yandex.functionTrigger.FunctionTriggerTimer")]
    public interface IFunctionTriggerTimer
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#cron_expression FunctionTrigger#cron_expression}.</summary>
        [JsiiProperty(name: "cronExpression", typeJson: "{\"primitive\":\"string\"}")]
        string CronExpression
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFunctionTriggerTimer), fullyQualifiedName: "yandex.functionTrigger.FunctionTriggerTimer")]
        internal sealed class _Proxy : DeputyBase, yandex.FunctionTrigger.IFunctionTriggerTimer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#cron_expression FunctionTrigger#cron_expression}.</summary>
            [JsiiProperty(name: "cronExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string CronExpression
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
