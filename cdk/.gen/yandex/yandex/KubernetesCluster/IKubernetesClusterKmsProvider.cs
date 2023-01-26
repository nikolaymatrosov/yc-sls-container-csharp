using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterKmsProvider), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterKmsProvider")]
    public interface IKubernetesClusterKmsProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#key_id KubernetesCluster#key_id}.</summary>
        [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterKmsProvider), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterKmsProvider")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesCluster.IKubernetesClusterKmsProvider
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#key_id KubernetesCluster#key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
