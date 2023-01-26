using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    [JsiiClass(nativeType: typeof(yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerOutputReference), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MdbKafkaConnectorConnectorConfigMirrormakerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MdbKafkaConnectorConnectorConfigMirrormakerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MdbKafkaConnectorConnectorConfigMirrormakerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbKafkaConnectorConnectorConfigMirrormakerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSourceCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceCluster\"}}]")]
        public virtual void PutSourceCluster(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTargetCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerTargetCluster\"}}]")]
        public virtual void PutTargetCluster(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerTargetCluster @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerTargetCluster)}, new object[]{@value});
        }

        [JsiiProperty(name: "sourceCluster", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterOutputReference\"}")]
        public virtual yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterOutputReference SourceCluster
        {
            get => GetInstanceProperty<yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterOutputReference>()!;
        }

        [JsiiProperty(name: "targetCluster", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerTargetClusterOutputReference\"}")]
        public virtual yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerTargetClusterOutputReference TargetCluster
        {
            get => GetInstanceProperty<yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerTargetClusterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationFactorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicationFactorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceClusterInput", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceCluster\"}", isOptional: true)]
        public virtual yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster? SourceClusterInput
        {
            get => GetInstanceProperty<yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetClusterInput", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerTargetCluster\"}", isOptional: true)]
        public virtual yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerTargetCluster? TargetClusterInput
        {
            get => GetInstanceProperty<yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerTargetCluster?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "topicsInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TopicsInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicationFactor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "topics", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Topics
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormaker\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormaker cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormaker).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
