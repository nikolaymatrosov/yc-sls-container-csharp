using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstance
{
    [JsiiInterface(nativeType: typeof(IDataYandexComputeInstancePlacementPolicy), fullyQualifiedName: "yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicy")]
    public interface IDataYandexComputeInstancePlacementPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#host_affinity_rules DataYandexComputeInstance#host_affinity_rules}.</summary>
        [JsiiProperty(name: "hostAffinityRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyHostAffinityRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HostAffinityRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#placement_group_id DataYandexComputeInstance#placement_group_id}.</summary>
        [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PlacementGroupId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexComputeInstancePlacementPolicy), fullyQualifiedName: "yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexComputeInstance.IDataYandexComputeInstancePlacementPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#host_affinity_rules DataYandexComputeInstance#host_affinity_rules}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hostAffinityRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstancePlacementPolicyHostAffinityRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HostAffinityRules
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#placement_group_id DataYandexComputeInstance#placement_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placementGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PlacementGroupId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
