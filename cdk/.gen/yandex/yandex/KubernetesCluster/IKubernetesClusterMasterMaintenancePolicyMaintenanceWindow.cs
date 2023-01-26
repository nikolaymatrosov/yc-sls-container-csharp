using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterMasterMaintenancePolicyMaintenanceWindow), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicyMaintenanceWindow")]
    public interface IKubernetesClusterMasterMaintenancePolicyMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#duration KubernetesCluster#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        string Duration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#start_time KubernetesCluster#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        string StartTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#day KubernetesCluster#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Day
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterMasterMaintenancePolicyMaintenanceWindow), fullyQualifiedName: "yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicyMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicyMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#duration KubernetesCluster#duration}.</summary>
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
            public string Duration
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#start_time KubernetesCluster#start_time}.</summary>
            [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
            public string StartTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#day KubernetesCluster#day}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Day
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
