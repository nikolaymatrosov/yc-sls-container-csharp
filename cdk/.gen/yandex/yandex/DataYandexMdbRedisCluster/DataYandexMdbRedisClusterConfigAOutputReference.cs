using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbRedisCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbRedisCluster.DataYandexMdbRedisClusterConfigAOutputReference), fullyQualifiedName: "yandex.dataYandexMdbRedisCluster.DataYandexMdbRedisClusterConfigAOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexMdbRedisClusterConfigAOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexMdbRedisClusterConfigAOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexMdbRedisClusterConfigAOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbRedisClusterConfigAOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "clientOutputBufferLimitNormal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientOutputBufferLimitNormal
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientOutputBufferLimitPubsub", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientOutputBufferLimitPubsub
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "databases", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Databases
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MaxmemoryPolicy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotifyKeyspaceEvents
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "slowlogLogSlowerThan", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SlowlogLogSlowerThan
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "slowlogMaxLen", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SlowlogMaxLen
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Timeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbRedisCluster.DataYandexMdbRedisClusterConfigA\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbRedisCluster.IDataYandexMdbRedisClusterConfigA? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbRedisCluster.IDataYandexMdbRedisClusterConfigA?>();
            set => SetInstanceProperty(value);
        }
    }
}
