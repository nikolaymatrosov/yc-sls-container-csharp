using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexIamPolicy
{
    [JsiiInterface(nativeType: typeof(IDataYandexIamPolicyBinding), fullyQualifiedName: "yandex.dataYandexIamPolicy.DataYandexIamPolicyBinding")]
    public interface IDataYandexIamPolicyBinding
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/iam_policy#members DataYandexIamPolicy#members}.</summary>
        [JsiiProperty(name: "members", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Members
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/iam_policy#role DataYandexIamPolicy#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexIamPolicyBinding), fullyQualifiedName: "yandex.dataYandexIamPolicy.DataYandexIamPolicyBinding")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexIamPolicy.IDataYandexIamPolicyBinding
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/iam_policy#members DataYandexIamPolicy#members}.</summary>
            [JsiiProperty(name: "members", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Members
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/iam_policy#role DataYandexIamPolicy#role}.</summary>
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
