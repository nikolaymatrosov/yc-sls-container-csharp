using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.computeInstance.ComputeInstanceNetworkInterfaceNatDnsRecord")]
    public class ComputeInstanceNetworkInterfaceNatDnsRecord : yandex.ComputeInstance.IComputeInstanceNetworkInterfaceNatDnsRecord
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#fqdn ComputeInstance#fqdn}.</summary>
        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public string Fqdn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#dns_zone_id ComputeInstance#dns_zone_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dnsZoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DnsZoneId
        {
            get;
            set;
        }

        private object? _ptr;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#ptr ComputeInstance#ptr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ptr", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Ptr
        {
            get => _ptr;
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
                _ptr = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#ttl ComputeInstance#ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ttl
        {
            get;
            set;
        }
    }
}
