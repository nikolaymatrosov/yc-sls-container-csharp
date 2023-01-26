using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ContainerRepositoryLifecyclePolicy
{
    [JsiiByValue(fqn: "yandex.containerRepositoryLifecyclePolicy.ContainerRepositoryLifecyclePolicyRule")]
    public class ContainerRepositoryLifecyclePolicyRule : yandex.ContainerRepositoryLifecyclePolicy.IContainerRepositoryLifecyclePolicyRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#description ContainerRepositoryLifecyclePolicy#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#expire_period ContainerRepositoryLifecyclePolicy#expire_period}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expirePeriod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExpirePeriod
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#retained_top ContainerRepositoryLifecyclePolicy#retained_top}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "retainedTop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetainedTop
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#tag_regexp ContainerRepositoryLifecyclePolicy#tag_regexp}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagRegexp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TagRegexp
        {
            get;
            set;
        }

        private object? _untagged;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/container_repository_lifecycle_policy#untagged ContainerRepositoryLifecyclePolicy#untagged}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "untagged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Untagged
        {
            get => _untagged;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _untagged = value;
            }
        }
    }
}
