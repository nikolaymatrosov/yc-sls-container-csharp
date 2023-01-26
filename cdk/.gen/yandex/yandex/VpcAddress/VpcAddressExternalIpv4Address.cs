using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.VpcAddress
{
    [JsiiByValue(fqn: "yandex.vpcAddress.VpcAddressExternalIpv4Address")]
    public class VpcAddressExternalIpv4Address : yandex.VpcAddress.IVpcAddressExternalIpv4Address
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_address#ddos_protection_provider VpcAddress#ddos_protection_provider}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ddosProtectionProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DdosProtectionProvider
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_address#outgoing_smtp_capability VpcAddress#outgoing_smtp_capability}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "outgoingSmtpCapability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OutgoingSmtpCapability
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_address#zone_id VpcAddress#zone_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ZoneId
        {
            get;
            set;
        }
    }
}
