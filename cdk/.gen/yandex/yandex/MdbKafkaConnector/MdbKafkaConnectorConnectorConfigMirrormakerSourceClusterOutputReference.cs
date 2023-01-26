using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbKafkaConnector
{
    [JsiiClass(nativeType: typeof(yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterOutputReference), fullyQualifiedName: "yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putExternalCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExternalCluster(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putThisCluster", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisCluster\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutThisCluster(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisCluster[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisCluster).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisCluster).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAlias")]
        public virtual void ResetAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExternalCluster")]
        public virtual void ResetExternalCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThisCluster")]
        public virtual void ResetThisCluster()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "externalCluster", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalClusterList\"}")]
        public virtual yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalClusterList ExternalCluster
        {
            get => GetInstanceProperty<yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalClusterList>()!;
        }

        [JsiiProperty(name: "thisCluster", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisClusterList\"}")]
        public virtual yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisClusterList ThisCluster
        {
            get => GetInstanceProperty<yandex.MdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisClusterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "externalClusterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterExternalCluster\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExternalClusterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thisClusterInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceClusterThisCluster\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ThisClusterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbKafkaConnector.MdbKafkaConnectorConnectorConfigMirrormakerSourceCluster\"}", isOptional: true)]
        public virtual yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbKafkaConnector.IMdbKafkaConnectorConnectorConfigMirrormakerSourceCluster?>();
            set => SetInstanceProperty(value);
        }
    }
}
