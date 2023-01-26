using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMysqlCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserOutputReference), fullyQualifiedName: "yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexMdbMysqlClusterUserOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexMdbMysqlClusterUserOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataYandexMdbMysqlClusterUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbMysqlClusterUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authenticationPlugin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationPlugin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "connectionLimits", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserConnectionLimitsList\"}")]
        public virtual yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserConnectionLimitsList ConnectionLimits
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserConnectionLimitsList>()!;
        }

        [JsiiProperty(name: "globalPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GlobalPermissions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "permission", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserPermissionList\"}")]
        public virtual yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserPermissionList Permission
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUserPermissionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMysqlCluster.DataYandexMdbMysqlClusterUser\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbMysqlCluster.IDataYandexMdbMysqlClusterUser? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMysqlCluster.IDataYandexMdbMysqlClusterUser?>();
            set => SetInstanceProperty(value);
        }
    }
}
