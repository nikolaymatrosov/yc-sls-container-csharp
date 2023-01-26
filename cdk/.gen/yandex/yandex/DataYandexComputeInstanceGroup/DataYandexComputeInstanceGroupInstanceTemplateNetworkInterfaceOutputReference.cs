using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstanceGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceOutputReference), fullyQualifiedName: "yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dnsRecord", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceDnsRecordList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceDnsRecordList DnsRecord
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceDnsRecordList>()!;
        }

        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv4", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Ipv4
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ipv6", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Ipv6
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ipv6Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ipv6Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipv6DnsRecord", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecordList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecordList Ipv6DnsRecord
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceIpv6DnsRecordList>()!;
        }

        [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Nat
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "natDnsRecord", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecordList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecordList NatDnsRecord
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterfaceNatDnsRecordList>()!;
        }

        [JsiiProperty(name: "natIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NatIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateNetworkInterface\"}", isOptional: true)]
        public virtual yandex.DataYandexComputeInstanceGroup.IDataYandexComputeInstanceGroupInstanceTemplateNetworkInterface? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.IDataYandexComputeInstanceGroupInstanceTemplateNetworkInterface?>();
            set => SetInstanceProperty(value);
        }
    }
}
