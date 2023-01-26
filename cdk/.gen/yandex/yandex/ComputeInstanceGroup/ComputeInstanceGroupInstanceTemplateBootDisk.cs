using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiByValue(fqn: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDisk")]
    public class ComputeInstanceGroupInstanceTemplateBootDisk : yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#device_name ComputeInstanceGroup#device_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#disk_id ComputeInstanceGroup#disk_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiskId
        {
            get;
            set;
        }

        /// <summary>initialize_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#initialize_params ComputeInstanceGroup#initialize_params}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initializeParams", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParams\"}", isOptional: true)]
        public yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDiskInitializeParams? InitializeParams
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#mode ComputeInstanceGroup#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }
    }
}
