using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityOutputReference), fullyQualifiedName: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MdbMongodbClusterClusterConfigMongodSecurityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MdbMongodbClusterClusterConfigMongodSecurityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MdbMongodbClusterClusterConfigMongodSecurityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbMongodbClusterClusterConfigMongodSecurityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKmip", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityKmip\"}}]")]
        public virtual void PutKmip(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurityKmip @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurityKmip)}, new object[]{@value});
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

        [JsiiProperty(name: "kmip", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityKmipOutputReference\"}")]
        public virtual yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityKmipOutputReference Kmip
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityKmipOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableEncryptionInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableEncryptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmipInput", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityKmip\"}", isOptional: true)]
        public virtual yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurityKmip? KmipInput
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurityKmip?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurity\"}", isOptional: true)]
        public virtual yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity? InternalValue
        {
            get => GetInstanceProperty<yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurity?>();
            set => SetInstanceProperty(value);
        }
    }
}
