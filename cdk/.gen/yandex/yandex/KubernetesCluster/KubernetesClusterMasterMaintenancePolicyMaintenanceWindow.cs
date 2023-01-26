using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.kubernetesCluster.KubernetesClusterMasterMaintenancePolicyMaintenanceWindow")]
    public class KubernetesClusterMasterMaintenancePolicyMaintenanceWindow : yandex.KubernetesCluster.IKubernetesClusterMasterMaintenancePolicyMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#duration KubernetesCluster#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}")]
        public string Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#start_time KubernetesCluster#start_time}.</summary>
        [JsiiProperty(name: "startTime", typeJson: "{\"primitive\":\"string\"}")]
        public string StartTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_cluster#day KubernetesCluster#day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Day
        {
            get;
            set;
        }
    }
}
