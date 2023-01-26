using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexKubernetesCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterOutputReference), fullyQualifiedName: "yandex.dataYandexKubernetesCluster.DataYandexKubernetesClusterMasterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexKubernetesClusterMasterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexKubernetesClusterMasterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexKubernetesClusterMasterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexKubernetesClusterMasterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clusterCaCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClusterCaCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalV4Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalV4Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalV4Endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalV4Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalV6Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalV6Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalV6Endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalV6Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "internalV4Address", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalV4Address
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "internalV4Endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InternalV4Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maintenancePolicy", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesCluster.DataYandexKubernetesClusterMasterMaintenancePolicyList\"}")]
        public virtual yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterMaintenancePolicyList MaintenancePolicy
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterMaintenancePolicyList>()!;
        }

        [JsiiProperty(name: "publicIp", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PublicIp
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "regional", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesCluster.DataYandexKubernetesClusterMasterRegionalList\"}")]
        public virtual yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterRegionalList Regional
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterRegionalList>()!;
        }

        [JsiiProperty(name: "securityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionInfo", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesCluster.DataYandexKubernetesClusterMasterVersionInfoList\"}")]
        public virtual yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterVersionInfoList VersionInfo
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterVersionInfoList>()!;
        }

        [JsiiProperty(name: "zonal", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesCluster.DataYandexKubernetesClusterMasterZonalList\"}")]
        public virtual yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterZonalList Zonal
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesCluster.DataYandexKubernetesClusterMasterZonalList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesCluster.DataYandexKubernetesClusterMaster\"}", isOptional: true)]
        public virtual yandex.DataYandexKubernetesCluster.IDataYandexKubernetesClusterMaster? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesCluster.IDataYandexKubernetesClusterMaster?>();
            set => SetInstanceProperty(value);
        }
    }
}
