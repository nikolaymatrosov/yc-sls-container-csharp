using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexLbNetworkLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerListenerOutputReference), fullyQualifiedName: "yandex.dataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerListenerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexLbNetworkLoadBalancerListenerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexLbNetworkLoadBalancerListenerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexLbNetworkLoadBalancerListenerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexLbNetworkLoadBalancerListenerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "externalAddressSpec", typeJson: "{\"fqn\":\"yandex.dataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerListenerExternalAddressSpecList\"}")]
        public virtual yandex.DataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerListenerExternalAddressSpecList ExternalAddressSpec
        {
            get => GetInstanceProperty<yandex.DataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerListenerExternalAddressSpecList>()!;
        }

        [JsiiProperty(name: "internalAddressSpec", typeJson: "{\"fqn\":\"yandex.dataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerListenerInternalAddressSpecList\"}")]
        public virtual yandex.DataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerListenerInternalAddressSpecList InternalAddressSpec
        {
            get => GetInstanceProperty<yandex.DataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerListenerInternalAddressSpecList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Protocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TargetPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerListener\"}", isOptional: true)]
        public virtual yandex.DataYandexLbNetworkLoadBalancer.IDataYandexLbNetworkLoadBalancerListener? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexLbNetworkLoadBalancer.IDataYandexLbNetworkLoadBalancerListener?>();
            set => SetInstanceProperty(value);
        }
    }
}
