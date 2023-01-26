using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiInterface(nativeType: typeof(IKubernetesNodeGroupScalePolicy), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicy")]
    public interface IKubernetesNodeGroupScalePolicy
    {
        /// <summary>auto_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#auto_scale KubernetesNodeGroup#auto_scale}
        /// </remarks>
        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyAutoScale\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyAutoScale? AutoScale
        {
            get
            {
                return null;
            }
        }

        /// <summary>fixed_scale block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#fixed_scale KubernetesNodeGroup#fixed_scale}
        /// </remarks>
        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyFixedScale\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyFixedScale? FixedScale
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesNodeGroupScalePolicy), fullyQualifiedName: "yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>auto_scale block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#auto_scale KubernetesNodeGroup#auto_scale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyAutoScale\"}", isOptional: true)]
            public yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyAutoScale? AutoScale
            {
                get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyAutoScale?>();
            }

            /// <summary>fixed_scale block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#fixed_scale KubernetesNodeGroup#fixed_scale}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.kubernetesNodeGroup.KubernetesNodeGroupScalePolicyFixedScale\"}", isOptional: true)]
            public yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyFixedScale? FixedScale
            {
                get => GetInstanceProperty<yandex.KubernetesNodeGroup.IKubernetesNodeGroupScalePolicyFixedScale?>();
            }
        }
    }
}
