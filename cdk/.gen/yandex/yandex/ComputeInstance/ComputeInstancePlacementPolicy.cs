using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    [JsiiByValue(fqn: "yandex.computeInstance.ComputeInstancePlacementPolicy")]
    public class ComputeInstancePlacementPolicy : yandex.ComputeInstance.IComputeInstancePlacementPolicy
    {
        private object? _hostAffinityRules;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#host_affinity_rules ComputeInstance#host_affinity_rules}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostAffinityRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstance.ComputeInstancePlacementPolicyHostAffinityRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case yandex.ComputeInstance.IComputeInstancePlacementPolicyHostAffinityRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstance.IComputeInstancePlacementPolicyHostAffinityRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hostAffinityRules = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#placement_group_id ComputeInstance#placement_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PlacementGroupId
        {
            get;
            set;
        }
    }
}
