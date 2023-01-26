using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceGroupInstanceTemplateBootDisk), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDisk")]
    public interface IComputeInstanceGroupInstanceTemplateBootDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#device_name ComputeInstanceGroup#device_name}.</summary>
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#disk_id ComputeInstanceGroup#disk_id}.</summary>
        [JsiiProperty(name: "diskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiskId
        {
            get
            {
                return null;
            }
        }

        /// <summary>initialize_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#initialize_params ComputeInstanceGroup#initialize_params}
        /// </remarks>
        [JsiiProperty(name: "initializeParams", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParams\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDiskInitializeParams? InitializeParams
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#mode ComputeInstanceGroup#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceGroupInstanceTemplateBootDisk), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDisk")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDisk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#device_name ComputeInstanceGroup#device_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#disk_id ComputeInstanceGroup#disk_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiskId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>initialize_params block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#initialize_params ComputeInstanceGroup#initialize_params}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "initializeParams", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParams\"}", isOptional: true)]
            public yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDiskInitializeParams? InitializeParams
            {
                get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDiskInitializeParams?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#mode ComputeInstanceGroup#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
