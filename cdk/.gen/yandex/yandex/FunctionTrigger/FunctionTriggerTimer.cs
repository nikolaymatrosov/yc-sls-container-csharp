using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionTrigger
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.functionTrigger.FunctionTriggerTimer")]
    public class FunctionTriggerTimer : yandex.FunctionTrigger.IFunctionTriggerTimer
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger#cron_expression FunctionTrigger#cron_expression}.</summary>
        [JsiiProperty(name: "cronExpression", typeJson: "{\"primitive\":\"string\"}")]
        public string CronExpression
        {
            get;
            set;
        }
    }
}
