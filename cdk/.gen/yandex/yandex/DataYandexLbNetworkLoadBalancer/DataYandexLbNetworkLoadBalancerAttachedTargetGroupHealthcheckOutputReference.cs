using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexLbNetworkLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference), fullyQualifiedName: "yandex.dataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "healthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HealthyThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "httpOptions", typeJson: "{\"fqn\":\"yandex.dataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptionsList\"}")]
        public virtual yandex.DataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptionsList HttpOptions
        {
            get => GetInstanceProperty<yandex.DataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckHttpOptionsList>()!;
        }

        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Interval
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tcpOptions", typeJson: "{\"fqn\":\"yandex.dataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsList\"}")]
        public virtual yandex.DataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsList TcpOptions
        {
            get => GetInstanceProperty<yandex.DataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsList>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "unhealthyThreshold", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double UnhealthyThreshold
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexLbNetworkLoadBalancer.DataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheck\"}", isOptional: true)]
        public virtual yandex.DataYandexLbNetworkLoadBalancer.IDataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheck? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexLbNetworkLoadBalancer.IDataYandexLbNetworkLoadBalancerAttachedTargetGroupHealthcheck?>();
            set => SetInstanceProperty(value);
        }
    }
}
