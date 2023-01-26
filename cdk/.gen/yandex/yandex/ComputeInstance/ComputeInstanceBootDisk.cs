using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    [JsiiByValue(fqn: "yandex.computeInstance.ComputeInstanceBootDisk")]
    public class ComputeInstanceBootDisk : yandex.ComputeInstance.IComputeInstanceBootDisk
    {
        private object? _autoDelete;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#auto_delete ComputeInstance#auto_delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoDelete", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AutoDelete
        {
            get => _autoDelete;
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
                _autoDelete = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#device_name ComputeInstance#device_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeviceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#disk_id ComputeInstance#disk_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "diskId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DiskId
        {
            get;
            set;
        }

        /// <summary>initialize_params block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#initialize_params ComputeInstance#initialize_params}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initializeParams", typeJson: "{\"fqn\":\"yandex.computeInstance.ComputeInstanceBootDiskInitializeParams\"}", isOptional: true)]
        public yandex.ComputeInstance.IComputeInstanceBootDiskInitializeParams? InitializeParams
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#mode ComputeInstance#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }
    }
}
