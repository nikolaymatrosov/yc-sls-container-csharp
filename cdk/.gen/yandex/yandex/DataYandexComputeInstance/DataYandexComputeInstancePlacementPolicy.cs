using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstance
{
    [JsiiByValue(fqn: "yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicy")]
    public class DataYandexComputeInstancePlacementPolicy : yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicy
    {
        private object? _hostAffinityRules;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#host_affinity_rules DataYandexComputeInstance#host_affinity_rules}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostAffinityRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyHostAffinityRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HostAffinityRules
        {
            get => _hostAffinityRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicyHostAffinityRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicyHostAffinityRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hostAffinityRules = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#placement_group_id DataYandexComputeInstance#placement_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlacementGroupId
        {
            get;
            set;
        }
    }
}
