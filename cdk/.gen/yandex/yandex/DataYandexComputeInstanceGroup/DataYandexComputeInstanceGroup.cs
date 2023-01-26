using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstanceGroup
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance_group yandex_compute_instance_group}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroup), fullyQualifiedName: "yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroup", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupConfig\"}}]")]
    public class DataYandexComputeInstanceGroup : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance_group yandex_compute_instance_group} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexComputeInstanceGroup(Constructs.Construct scope, string id, yandex.DataYandexComputeInstanceGroup.IDataYandexComputeInstanceGroupConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexComputeInstanceGroup.IDataYandexComputeInstanceGroupConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstanceGroup(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexComputeInstanceGroup(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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
        = GetStaticProperty<string>(typeof(yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroup))!;

        [JsiiProperty(name: "allocationPolicy", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupAllocationPolicyList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupAllocationPolicyList AllocationPolicy
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupAllocationPolicyList>()!;
        }

        [JsiiProperty(name: "applicationBalancerState", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupApplicationBalancerStateList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupApplicationBalancerStateList ApplicationBalancerState
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupApplicationBalancerStateList>()!;
        }

        [JsiiProperty(name: "applicationLoadBalancer", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupApplicationLoadBalancerList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupApplicationLoadBalancerList ApplicationLoadBalancer
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupApplicationLoadBalancerList>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deletionProtection", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DeletionProtection
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "deployPolicy", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupDeployPolicyList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupDeployPolicyList DeployPolicy
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupDeployPolicyList>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FolderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "healthCheck", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupHealthCheckList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupHealthCheckList HealthCheck
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupHealthCheckList>()!;
        }

        [JsiiProperty(name: "instances", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstancesList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstancesList Instances
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstancesList>()!;
        }

        [JsiiProperty(name: "instanceTemplate", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateList InstanceTemplate
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupInstanceTemplateList>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "loadBalancer", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupLoadBalancerList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupLoadBalancerList LoadBalancer
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupLoadBalancerList>()!;
        }

        [JsiiProperty(name: "loadBalancerState", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupLoadBalancerStateList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupLoadBalancerStateList LoadBalancerState
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupLoadBalancerStateList>()!;
        }

        [JsiiProperty(name: "maxCheckingHealthDuration", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxCheckingHealthDuration
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scalePolicy", typeJson: "{\"fqn\":\"yandex.dataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupScalePolicyList\"}")]
        public virtual yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupScalePolicyList ScalePolicy
        {
            get => GetInstanceProperty<yandex.DataYandexComputeInstanceGroup.DataYandexComputeInstanceGroupScalePolicyList>()!;
        }

        [JsiiProperty(name: "serviceAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceAccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "variables", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Variables
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceGroupId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
