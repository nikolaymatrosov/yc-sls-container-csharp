using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstance
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceOutputReference), fullyQualifiedName: "yandex.dataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexComputeInstanceNetworkInterfaceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexComputeInstanceNetworkInterfaceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexComputeInstanceNetworkInterfaceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstanceNetworkInterfaceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "dnsRecord", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceDnsRecordList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceDnsRecordList DnsRecord
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceDnsRecordList>()!;
        }

        [JsiiProperty(name: "index", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Index
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "ipv6DnsRecord", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceIpv6DnsRecordList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceIpv6DnsRecordList Ipv6DnsRecord
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceIpv6DnsRecordList>()!;
        }

        [JsiiProperty(name: "macAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MacAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nat", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Nat
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "natDnsRecord", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceNatDnsRecordList\"}")]
        public virtual yandex.DataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceNatDnsRecordList NatDnsRecord
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.DataYandexComputeInstanceNetworkInterfaceNatDnsRecordList>()!;
        }

        [JsiiProperty(name: "natIpAddress", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NatIpAddress
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "natIpVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NatIpVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstance.DataYandexComputeInstanceNetworkInterface\"}", isOptional: true)]
        public virtual yandex.DataYandexComputeInstance.IDataYandexComputeInstanceNetworkInterface? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstance.IDataYandexComputeInstanceNetworkInterface?>();
            set => SetInstanceProperty(value);
        }
    }
}
