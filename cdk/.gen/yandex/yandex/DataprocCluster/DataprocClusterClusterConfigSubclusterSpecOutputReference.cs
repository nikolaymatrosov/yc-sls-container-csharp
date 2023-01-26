using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataprocCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataprocCluster.DataprocClusterClusterConfigSubclusterSpecOutputReference), fullyQualifiedName: "yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataprocClusterClusterConfigSubclusterSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataprocClusterClusterConfigSubclusterSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataprocClusterClusterConfigSubclusterSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataprocClusterClusterConfigSubclusterSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoscalingConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig\"}}]")]
        public virtual void PutAutoscalingConfig(yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecResources\"}}]")]
        public virtual void PutResources(yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssignPublicIp")]
        public virtual void ResetAssignPublicIp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoscalingConfig")]
        public virtual void ResetAutoscalingConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoscalingConfig", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfigOutputReference\"}")]
        public virtual yandex.DataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfigOutputReference AutoscalingConfig
        {
            get => GetInstanceProperty<yandex.DataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfigOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecResourcesOutputReference\"}")]
        public virtual yandex.DataprocCluster.DataprocClusterClusterConfigSubclusterSpecResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.DataprocCluster.DataprocClusterClusterConfigSubclusterSpecResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assignPublicIpInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AssignPublicIpInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoscalingConfigInput", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecAutoscalingConfig\"}", isOptional: true)]
        public virtual yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig? AutoscalingConfigInput
        {
            get => GetInstanceProperty<yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecAutoscalingConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostsCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HostsCountInput
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
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecResources\"}", isOptional: true)]
        public virtual yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpecResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AssignPublicIp
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

        [JsiiProperty(name: "hostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HostsCount
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

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpec\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpec cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpec).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
