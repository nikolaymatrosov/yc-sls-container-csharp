using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexDataprocCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexDataprocCluster.DataYandexDataprocClusterClusterConfigSubclusterSpecOutputReference), fullyQualifiedName: "yandex.dataYandexDataprocCluster.DataYandexDataprocClusterClusterConfigSubclusterSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexDataprocClusterClusterConfigSubclusterSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexDataprocClusterClusterConfigSubclusterSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexDataprocClusterClusterConfigSubclusterSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexDataprocClusterClusterConfigSubclusterSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable AssignPublicIp
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "autoscalingConfig", typeJson: "{\"fqn\":\"yandex.dataYandexDataprocCluster.DataYandexDataprocClusterClusterConfigSubclusterSpecAutoscalingConfigList\"}")]
        public virtual yandex.DataYandexDataprocCluster.DataYandexDataprocClusterClusterConfigSubclusterSpecAutoscalingConfigList AutoscalingConfig
        {
            get => GetInstanceProperty<yandex.DataYandexDataprocCluster.DataYandexDataprocClusterClusterConfigSubclusterSpecAutoscalingConfigList>()!;
        }

        [JsiiProperty(name: "hostsCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double HostsCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexDataprocCluster.DataYandexDataprocClusterClusterConfigSubclusterSpecResourcesList\"}")]
        public virtual yandex.DataYandexDataprocCluster.DataYandexDataprocClusterClusterConfigSubclusterSpecResourcesList Resources
        {
            get => GetInstanceProperty<yandex.DataYandexDataprocCluster.DataYandexDataprocClusterClusterConfigSubclusterSpecResourcesList>()!;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexDataprocCluster.DataYandexDataprocClusterClusterConfigSubclusterSpec\"}", isOptional: true)]
        public virtual yandex.DataYandexDataprocCluster.IDataYandexDataprocClusterClusterConfigSubclusterSpec? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexDataprocCluster.IDataYandexDataprocClusterClusterConfigSubclusterSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
