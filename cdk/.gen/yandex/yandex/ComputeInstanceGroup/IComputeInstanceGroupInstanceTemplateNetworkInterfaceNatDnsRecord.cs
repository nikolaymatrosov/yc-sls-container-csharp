using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecord), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecord")]
    public interface IComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#fqdn ComputeInstanceGroup#fqdn}.</summary>
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        string Fqdn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#dns_zone_id ComputeInstanceGroup#dns_zone_id}.</summary>
        [JsiiProperty(name: "dnsZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DnsZoneId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#ptr ComputeInstanceGroup#ptr}.</summary>
        [JsiiProperty(name: "ptr", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Ptr
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#ttl ComputeInstanceGroup#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ttl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecord), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecord")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecord
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#fqdn ComputeInstanceGroup#fqdn}.</summary>
            [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
            public string Fqdn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#dns_zone_id ComputeInstanceGroup#dns_zone_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dnsZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DnsZoneId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#ptr ComputeInstanceGroup#ptr}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ptr", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Ptr
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#ttl ComputeInstanceGroup#ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ttl
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
