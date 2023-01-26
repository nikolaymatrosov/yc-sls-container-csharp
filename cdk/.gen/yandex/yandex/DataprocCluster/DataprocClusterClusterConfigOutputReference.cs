using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataprocCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataprocCluster.DataprocClusterClusterConfigOutputReference), fullyQualifiedName: "yandex.dataprocCluster.DataprocClusterClusterConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataprocClusterClusterConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataprocClusterClusterConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataprocClusterClusterConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataprocClusterClusterConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHadoop", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigHadoop\"}}]")]
        public virtual void PutHadoop(yandex.DataprocCluster.IDataprocClusterClusterConfigHadoop @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataprocCluster.IDataprocClusterClusterConfigHadoop)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSubclusterSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpec\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSubclusterSpec(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpec[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpec).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.DataprocCluster.IDataprocClusterClusterConfigSubclusterSpec).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHadoop")]
        public virtual void ResetHadoop()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVersionId")]
        public virtual void ResetVersionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hadoop", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigHadoopOutputReference\"}")]
        public virtual yandex.DataprocCluster.DataprocClusterClusterConfigHadoopOutputReference Hadoop
        {
            get => GetInstanceProperty<yandex.DataprocCluster.DataprocClusterClusterConfigHadoopOutputReference>()!;
        }

        [JsiiProperty(name: "subclusterSpec", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpecList\"}")]
        public virtual yandex.DataprocCluster.DataprocClusterClusterConfigSubclusterSpecList SubclusterSpec
        {
            get => GetInstanceProperty<yandex.DataprocCluster.DataprocClusterClusterConfigSubclusterSpecList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hadoopInput", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigHadoop\"}", isOptional: true)]
        public virtual yandex.DataprocCluster.IDataprocClusterClusterConfigHadoop? HadoopInput
        {
            get => GetInstanceProperty<yandex.DataprocCluster.IDataprocClusterClusterConfigHadoop?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subclusterSpecInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfigSubclusterSpec\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SubclusterSpecInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataprocCluster.DataprocClusterClusterConfig\"}", isOptional: true)]
        public virtual yandex.DataprocCluster.IDataprocClusterClusterConfig? InternalValue
        {
            get => GetInstanceProperty<yandex.DataprocCluster.IDataprocClusterClusterConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
