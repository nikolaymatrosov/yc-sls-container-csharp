using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexIamPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataYandexIamPolicy.DataYandexIamPolicyBinding")]
    public class DataYandexIamPolicyBinding : yandex.DataYandexIamPolicy.IDataYandexIamPolicyBinding
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/iam_policy#members DataYandexIamPolicy#members}.</summary>
        [JsiiProperty(name: "members", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Members
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/iam_policy#role DataYandexIamPolicy#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public string Role
        {
            get;
            set;
        }
    }
}
