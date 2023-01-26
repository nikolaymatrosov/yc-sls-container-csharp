using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group yandex_compute_instance_group}.</summary>
    [JsiiClass(nativeType: typeof(yandex.ComputeInstanceGroup.ComputeInstanceGroup), fullyQualifiedName: "yandex.computeInstanceGroup.ComputeInstanceGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupConfig\"}}]")]
    public class ComputeInstanceGroup : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group yandex_compute_instance_group} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ComputeInstanceGroup(Constructs.Construct scope, string id, yandex.ComputeInstanceGroup.IComputeInstanceGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.ComputeInstanceGroup.IComputeInstanceGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeInstanceGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeInstanceGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAllocationPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupAllocationPolicy\"}}]")]
        public virtual void PutAllocationPolicy(yandex.ComputeInstanceGroup.IComputeInstanceGroupAllocationPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupAllocationPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putApplicationLoadBalancer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupApplicationLoadBalancer\"}}]")]
        public virtual void PutApplicationLoadBalancer(yandex.ComputeInstanceGroup.IComputeInstanceGroupApplicationLoadBalancer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupApplicationLoadBalancer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeployPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupDeployPolicy\"}}]")]
        public virtual void PutDeployPolicy(yandex.ComputeInstanceGroup.IComputeInstanceGroupDeployPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupDeployPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHealthCheck", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupHealthCheck\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHealthCheck(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.ComputeInstanceGroup.IComputeInstanceGroupHealthCheck[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupHealthCheck).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupHealthCheck).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putInstanceTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplate\"}}]")]
        public virtual void PutInstanceTemplate(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLoadBalancer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupLoadBalancer\"}}]")]
        public virtual void PutLoadBalancer(yandex.ComputeInstanceGroup.IComputeInstanceGroupLoadBalancer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupLoadBalancer)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScalePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicy\"}}]")]
        public virtual void PutScalePolicy(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.ComputeInstanceGroup.IComputeInstanceGroupTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeInstanceGroup.IComputeInstanceGroupTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationLoadBalancer")]
        public virtual void ResetApplicationLoadBalancer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeletionProtection")]
        public virtual void ResetDeletionProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFolderId")]
        public virtual void ResetFolderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHealthCheck")]
        public virtual void ResetHealthCheck()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoadBalancer")]
        public virtual void ResetLoadBalancer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxCheckingHealthDuration")]
        public virtual void ResetMaxCheckingHealthDuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVariables")]
        public virtual void ResetVariables()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(yandex.ComputeInstanceGroup.ComputeInstanceGroup))!;

        [JsiiProperty(name: "allocationPolicy", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupAllocationPolicyOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupAllocationPolicyOutputReference AllocationPolicy
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupAllocationPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "applicationLoadBalancer", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupApplicationLoadBalancerOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupApplicationLoadBalancerOutputReference ApplicationLoadBalancer
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupApplicationLoadBalancerOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deployPolicy", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupDeployPolicyOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupDeployPolicyOutputReference DeployPolicy
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupDeployPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupHealthCheckList\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupHealthCheckList HealthCheck
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupHealthCheckList>()!;
        }

        [JsiiProperty(name: "instances", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstancesList\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupInstancesList Instances
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupInstancesList>()!;
        }

        [JsiiProperty(name: "instanceTemplate", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplateOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateOutputReference InstanceTemplate
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupInstanceTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "loadBalancer", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupLoadBalancerOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupLoadBalancerOutputReference LoadBalancer
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupLoadBalancerOutputReference>()!;
        }

        [JsiiProperty(name: "scalePolicy", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicyOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyOutputReference ScalePolicy
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupScalePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupTimeoutsOutputReference\"}")]
        public virtual yandex.ComputeInstanceGroup.ComputeInstanceGroupTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.ComputeInstanceGroupTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allocationPolicyInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupAllocationPolicy\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupAllocationPolicy? AllocationPolicyInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupAllocationPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationLoadBalancerInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupApplicationLoadBalancer\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupApplicationLoadBalancer? ApplicationLoadBalancerInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupApplicationLoadBalancer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deletionProtectionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeletionProtectionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deployPolicyInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupDeployPolicy\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupDeployPolicy? DeployPolicyInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupDeployPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "folderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FolderIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "healthCheckInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupHealthCheck\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HealthCheckInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceTemplateInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupInstanceTemplate\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplate? InstanceTemplateInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupInstanceTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loadBalancerInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupLoadBalancer\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupLoadBalancer? LoadBalancerInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupLoadBalancer?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxCheckingHealthDurationInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxCheckingHealthDurationInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scalePolicyInput", typeJson: "{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupScalePolicy\"}", isOptional: true)]
        public virtual yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicy? ScalePolicyInput
        {
            get => GetInstanceProperty<yandex.ComputeInstanceGroup.IComputeInstanceGroupScalePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.computeInstanceGroup.ComputeInstanceGroupTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "variablesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? VariablesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "deletionProtection", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DeletionProtection
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FolderId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
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

        [JsiiProperty(name: "maxCheckingHealthDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCheckingHealthDuration
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
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

        [JsiiProperty(name: "variables", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Variables
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
