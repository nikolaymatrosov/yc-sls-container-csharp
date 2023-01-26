using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiClass(nativeType: typeof(yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskOutputReference), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ComputeInstanceGroupInstanceTemplateBootDiskOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ComputeInstanceGroupInstanceTemplateBootDiskOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ComputeInstanceGroupInstanceTemplateBootDiskOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeInstanceGroupInstanceTemplateBootDiskOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInitializeParams", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParams\"}}]")]
        public virtual void PutInitializeParams(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDiskInitializeParams @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDiskInitializeParams)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDeviceName")]
        public virtual void ResetDeviceName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiskId")]
        public virtual void ResetDiskId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInitializeParams")]
        public virtual void ResetInitializeParams()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "initializeParams", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParamsOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParamsOutputReference InitializeParams
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParamsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DiskIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initializeParamsInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskInitializeParams\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDiskInitializeParams? InitializeParamsInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDiskInitializeParams?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deviceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "diskId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiskId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDisk\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDisk? InternalValue
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDisk?>();
            set => SetInstanceProperty(value);
        }
    }
}
