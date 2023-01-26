using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.KubernetesNodeGroup
{
    [JsiiByValue(fqn: "yandex.kubernetesNodeGroup.KubernetesNodeGroupInstanceTemplateSchedulingPolicy")]
    public class KubernetesNodeGroupInstanceTemplateSchedulingPolicy : yandex.KubernetesNodeGroup.IKubernetesNodeGroupInstanceTemplateSchedulingPolicy
    {
        private object? _preemptible;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/kubernetes_node_group#preemptible KubernetesNodeGroup#preemptible}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preemptible", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? Preemptible
        {
            get => _preemptible;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _preemptible = value;
            }
        }
    }
}
