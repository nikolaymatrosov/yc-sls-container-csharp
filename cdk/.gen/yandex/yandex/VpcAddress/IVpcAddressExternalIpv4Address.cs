using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.VpcAddress
{
    [JsiiInterface(nativeType: typeof(IVpcAddressExternalIpv4Address), fullyQualifiedName: "yandex.vpcAddress.VpcAddressExternalIpv4Address")]
    public interface IVpcAddressExternalIpv4Address
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_address#ddos_protection_provider VpcAddress#ddos_protection_provider}.</summary>
        [JsiiProperty(name: "ddosProtectionProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DdosProtectionProvider
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_address#outgoing_smtp_capability VpcAddress#outgoing_smtp_capability}.</summary>
        [JsiiProperty(name: "outgoingSmtpCapability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OutgoingSmtpCapability
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_address#zone_id VpcAddress#zone_id}.</summary>
        [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ZoneId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcAddressExternalIpv4Address), fullyQualifiedName: "yandex.vpcAddress.VpcAddressExternalIpv4Address")]
        internal sealed class _Proxy : DeputyBase, yandex.VpcAddress.IVpcAddressExternalIpv4Address
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_address#ddos_protection_provider VpcAddress#ddos_protection_provider}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ddosProtectionProvider", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DdosProtectionProvider
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_address#outgoing_smtp_capability VpcAddress#outgoing_smtp_capability}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "outgoingSmtpCapability", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OutgoingSmtpCapability
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_address#zone_id VpcAddress#zone_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zoneId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ZoneId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
