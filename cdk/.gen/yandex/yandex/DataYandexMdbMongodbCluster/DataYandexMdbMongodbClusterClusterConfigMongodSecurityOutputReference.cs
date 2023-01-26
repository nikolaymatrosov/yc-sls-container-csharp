using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMongodbCluster
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityOutputReference), fullyQualifiedName: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataYandexMdbMongodbClusterClusterConfigMongodSecurityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataYandexMdbMongodbClusterClusterConfigMongodSecurityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataYandexMdbMongodbClusterClusterConfigMongodSecurityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexMdbMongodbClusterClusterConfigMongodSecurityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKmip", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip\"}}]")]
        public virtual void PutKmip(yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnableEncryption")]
        public virtual void ResetEnableEncryption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmip")]
        public virtual void ResetKmip()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "kmip", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityKmipOutputReference\"}")]
        public virtual yandex.DataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityKmipOutputReference Kmip
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityKmipOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableEncryptionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableEncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmipInput", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip? KmipInput
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip?>();
        }

        [JsiiProperty(name: "enableEncryption", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableEncryption
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurity\"}", isOptional: true)]
        public virtual yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurity? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurity?>();
            set => SetInstanceProperty(value);
        }
    }
}
