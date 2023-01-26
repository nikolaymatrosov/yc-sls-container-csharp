using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbPostgresqlCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigAOutputReference), fullyQualifiedName: "yandex.dataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexMdbPostgresqlClusterConfigAOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexMdbPostgresqlClusterConfigAOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexMdbPostgresqlClusterConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbPostgresqlClusterConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "access", typeJson: "{\"fqn\":\"yandex.dataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigAccessList\"}")]
        public virtual yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigAccessList Access
        {
            get => GetInstanceProperty<yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigAccessList>()!;
        }

        [JsiiProperty(name: "autofailover", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Autofailover
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "backupRetainPeriodDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupRetainPeriodDays
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "backupWindowStart", typeJson: "{\"fqn\":\"yandex.dataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigBackupWindowStartList\"}")]
        public virtual yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigBackupWindowStartList BackupWindowStart
        {
            get => GetInstanceProperty<yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigBackupWindowStartList>()!;
        }

        [JsiiProperty(name: "performanceDiagnostics", typeJson: "{\"fqn\":\"yandex.dataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigPerformanceDiagnosticsList\"}")]
        public virtual yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigPerformanceDiagnosticsList PerformanceDiagnostics
        {
            get => GetInstanceProperty<yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigPerformanceDiagnosticsList>()!;
        }

        [JsiiProperty(name: "poolerConfig", typeJson: "{\"fqn\":\"yandex.dataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigPoolerConfigList\"}")]
        public virtual yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigPoolerConfigList PoolerConfig
        {
            get => GetInstanceProperty<yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigPoolerConfigList>()!;
        }

        [JsiiProperty(name: "postgresqlConfig", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap PostgresqlConfig
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.dataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigResourcesList\"}")]
        public virtual yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigResourcesList Resources
        {
            get => GetInstanceProperty<yandex.DataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigResourcesList>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbPostgresqlCluster.DataYandexMdbPostgresqlClusterConfigA\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbPostgresqlCluster.IDataYandexMdbPostgresqlClusterConfigA? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbPostgresqlCluster.IDataYandexMdbPostgresqlClusterConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
