using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    [JsiiClass(nativeType: typeof(yandex.KubernetesCluster.KubernetesClusterNetworkImplementationOutputReference), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterNetworkImplementationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KubernetesClusterNetworkImplementationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KubernetesClusterNetworkImplementationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KubernetesClusterNetworkImplementationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubernetesClusterNetworkImplementationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCilium", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementationCilium\"}}]")]
        public virtual void PutCilium(yandex.KubernetesCluster.IKubernetesClusterNetworkImplementationCilium @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.KubernetesCluster.IKubernetesClusterNetworkImplementationCilium)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCilium")]
        public virtual void ResetCilium()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cilium", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementationCiliumOutputReference\"}")]
        public virtual yandex.KubernetesCluster.KubernetesClusterNetworkImplementationCiliumOutputReference Cilium
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.KubernetesClusterNetworkImplementationCiliumOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "ciliumInput", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementationCilium\"}", isOptional: true)]
        public virtual yandex.KubernetesCluster.IKubernetesClusterNetworkImplementationCilium? CiliumInput
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterNetworkImplementationCilium?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.kubernetesCluster.KubernetesClusterNetworkImplementation\"}", isOptional: true)]
        public virtual yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation? InternalValue
        {
            get => GetInstanceProperty<yandex.KubernetesCluster.IKubernetesClusterNetworkImplementation?>();
            set => SetInstanceProperty(value);
        }
    }
}
