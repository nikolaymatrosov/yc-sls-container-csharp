using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    [JsiiClass(nativeType: typeof(yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateOutputReference), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ComputeInstanceGroupInstanceTemplateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ComputeInstanceGroupInstanceTemplateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ComputeInstanceGroupInstanceTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeInstanceGroupInstanceTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putBootDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDisk\"}}]")]
        public virtual void PutBootDisk(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDisk @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDisk)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkInterface", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkInterface\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkInterface(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateNetworkInterface[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateNetworkInterface).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateNetworkInterface).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNetworkSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkSettings\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutNetworkSettings(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateNetworkSettings[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateNetworkSettings).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateNetworkSettings).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlacementPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplatePlacementPolicy\"}}]")]
        public virtual void PutPlacementPolicy(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplatePlacementPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplatePlacementPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateResources\"}}]")]
        public virtual void PutResources(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchedulingPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateSchedulingPolicy\"}}]")]
        public virtual void PutSchedulingPolicy(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateSchedulingPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateSchedulingPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecondaryDisk", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateSecondaryDisk\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecondaryDisk(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateSecondaryDisk[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateSecondaryDisk).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateSecondaryDisk).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostname")]
        public virtual void ResetHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMetadata")]
        public virtual void ResetMetadata()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNetworkSettings")]
        public virtual void ResetNetworkSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlacementPolicy")]
        public virtual void ResetPlacementPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPlatformId")]
        public virtual void ResetPlatformId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulingPolicy")]
        public virtual void ResetSchedulingPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecondaryDisk")]
        public virtual void ResetSecondaryDisk()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetServiceAccountId")]
        public virtual void ResetServiceAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "bootDisk", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskOutputReference BootDisk
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDiskOutputReference>()!;
        }

        [JsiiProperty(name: "networkInterface", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkInterfaceList\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkInterfaceList NetworkInterface
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkInterfaceList>()!;
        }

        [JsiiProperty(name: "networkSettings", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkSettingsList\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkSettingsList NetworkSettings
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkSettingsList>()!;
        }

        [JsiiProperty(name: "placementPolicy", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplatePlacementPolicyOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplatePlacementPolicyOutputReference PlacementPolicy
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplatePlacementPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateResourcesOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateResourcesOutputReference>()!;
        }

        [JsiiProperty(name: "schedulingPolicy", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateSchedulingPolicyOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateSchedulingPolicyOutputReference SchedulingPolicy
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateSchedulingPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "secondaryDisk", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateSecondaryDiskList\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateSecondaryDiskList SecondaryDisk
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateSecondaryDiskList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bootDiskInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateBootDisk\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDisk? BootDiskInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateBootDisk?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "metadataInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? MetadataInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkInterfaceInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkInterface\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkInterfaceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkSettingsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateNetworkSettings\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? NetworkSettingsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "placementPolicyInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplatePlacementPolicy\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplatePlacementPolicy? PlacementPolicyInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplatePlacementPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "platformIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PlatformIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateResources\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulingPolicyInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateSchedulingPolicy\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateSchedulingPolicy? SchedulingPolicyInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplateSchedulingPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secondaryDiskInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateSecondaryDisk\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecondaryDiskInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Hostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "platformId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PlatformId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplate\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplate? InternalValue
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}
