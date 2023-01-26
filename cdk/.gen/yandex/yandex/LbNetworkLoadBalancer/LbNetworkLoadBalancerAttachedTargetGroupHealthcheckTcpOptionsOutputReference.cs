using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    [JsiiClass(nativeType: typeof(yandex.LbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsOutputReference), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions\"}", isOptional: true)]
        public virtual yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions? InternalValue
        {
            get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerAttachedTargetGroupHealthcheckTcpOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
