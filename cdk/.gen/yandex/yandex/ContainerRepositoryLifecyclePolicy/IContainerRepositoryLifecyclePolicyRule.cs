using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ContainerRepositoryLifecyclePolicy
{
    [JsiiInterface(nativeType: typeof(IContainerRepositoryLifecyclePolicyRule), fullyQualifiedName: "yandex.containerRepositoryLifecyclePolicy.ContainerRepositoryLifecyclePolicyRule")]
    public interface IContainerRepositoryLifecyclePolicyRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#description ContainerRepositoryLifecyclePolicy#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#expire_period ContainerRepositoryLifecyclePolicy#expire_period}.</summary>
        [JsiiProperty(name: "expirePeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpirePeriod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#retained_top ContainerRepositoryLifecyclePolicy#retained_top}.</summary>
        [JsiiProperty(name: "retainedTop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetainedTop
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#tag_regexp ContainerRepositoryLifecyclePolicy#tag_regexp}.</summary>
        [JsiiProperty(name: "tagRegexp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TagRegexp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#untagged ContainerRepositoryLifecyclePolicy#untagged}.</summary>
        [JsiiProperty(name: "untagged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Untagged
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IContainerRepositoryLifecyclePolicyRule), fullyQualifiedName: "yandex.containerRepositoryLifecyclePolicy.ContainerRepositoryLifecyclePolicyRule")]
        internal sealed class _Proxy : DeputyBase, yandex.ContainerRepositoryLifecyclePolicy.IContainerRepositoryLifecyclePolicyRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#description ContainerRepositoryLifecyclePolicy#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#expire_period ContainerRepositoryLifecyclePolicy#expire_period}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expirePeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpirePeriod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#retained_top ContainerRepositoryLifecyclePolicy#retained_top}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retainedTop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RetainedTop
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#tag_regexp ContainerRepositoryLifecyclePolicy#tag_regexp}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagRegexp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TagRegexp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#untagged ContainerRepositoryLifecyclePolicy#untagged}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "untagged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Untagged
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
