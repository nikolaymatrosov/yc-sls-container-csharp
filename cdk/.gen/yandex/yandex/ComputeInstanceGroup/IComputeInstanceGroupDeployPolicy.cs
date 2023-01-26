using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceGroupDeployPolicy), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupDeployPolicy")]
    public interface IComputeInstanceGroupDeployPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_expansion ComputeInstanceGroup#max_expansion}.</summary>
        [JsiiProperty(name: "maxExpansion", typeJson: "{\"primitive\":\"number\"}")]
        double MaxExpansion
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_unavailable ComputeInstanceGroup#max_unavailable}.</summary>
        [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}")]
        double MaxUnavailable
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_creating ComputeInstanceGroup#max_creating}.</summary>
        [JsiiProperty(name: "maxCreating", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCreating
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_deleting ComputeInstanceGroup#max_deleting}.</summary>
        [JsiiProperty(name: "maxDeleting", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxDeleting
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#startup_duration ComputeInstanceGroup#startup_duration}.</summary>
        [JsiiProperty(name: "startupDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartupDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#strategy ComputeInstanceGroup#strategy}.</summary>
        [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Strategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceGroupDeployPolicy), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupDeployPolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstanceGroup.IComputeInstanceGroupDeployPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_expansion ComputeInstanceGroup#max_expansion}.</summary>
            [JsiiProperty(name: "maxExpansion", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxExpansion
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_unavailable ComputeInstanceGroup#max_unavailable}.</summary>
            [JsiiProperty(name: "maxUnavailable", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxUnavailable
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_creating ComputeInstanceGroup#max_creating}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCreating", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCreating
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#max_deleting ComputeInstanceGroup#max_deleting}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxDeleting", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxDeleting
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#startup_duration ComputeInstanceGroup#startup_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startupDuration", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartupDuration
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#strategy ComputeInstanceGroup#strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "strategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Strategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
