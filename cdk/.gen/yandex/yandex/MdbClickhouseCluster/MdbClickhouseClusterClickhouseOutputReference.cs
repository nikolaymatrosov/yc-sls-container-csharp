using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseOutputReference), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbClickhouseClusterClickhouseOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbClickhouseClusterClickhouseOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbClickhouseClusterClickhouseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbClickhouseClusterClickhouseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfig\"}}]")]
        public virtual void PutConfig(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResources", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseResources\"}}]")]
        public virtual void PutResources(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseResources @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseResources)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConfig")]
        public virtual void ResetConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "config", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigOutputReference\"}")]
        public virtual yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigOutputReference Config
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseConfigOutputReference>()!;
        }

        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseResourcesOutputReference\"}")]
        public virtual yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseResourcesOutputReference Resources
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.MdbClickhouseClusterClickhouseResourcesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "configInput", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseConfig\"}", isOptional: true)]
        public virtual yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig? ConfigInput
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourcesInput", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouseResources\"}", isOptional: true)]
        public virtual yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseResources? ResourcesInput
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouseResources?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbClickhouseCluster.MdbClickhouseClusterClickhouse\"}", isOptional: true)]
        public virtual yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouse? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbClickhouseCluster.IMdbClickhouseClusterClickhouse?>();
            set => SetInstanceProperty(value);
        }
    }
}
