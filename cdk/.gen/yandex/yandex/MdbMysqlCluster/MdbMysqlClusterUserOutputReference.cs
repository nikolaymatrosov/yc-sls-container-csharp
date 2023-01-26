using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    [JsiiClass(nativeType: typeof(yandex.MdbMysqlCluster.MdbMysqlClusterUserOutputReference), fullyQualifiedName: "yandex.mdbMysqlCluster.MdbMysqlClusterUserOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MdbMysqlClusterUserOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public MdbMysqlClusterUserOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected MdbMysqlClusterUserOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MdbMysqlClusterUserOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnectionLimits", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimits\"}}]")]
        public virtual void PutConnectionLimits(yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPermission", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserPermission\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPermission(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.MdbMysqlCluster.IMdbMysqlClusterUserPermission[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterUserPermission).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterUserPermission).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthenticationPlugin")]
        public virtual void ResetAuthenticationPlugin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionLimits")]
        public virtual void ResetConnectionLimits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGlobalPermissions")]
        public virtual void ResetGlobalPermissions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermission")]
        public virtual void ResetPermission()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connectionLimits", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimitsOutputReference\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterUserConnectionLimitsOutputReference ConnectionLimits
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterUserConnectionLimitsOutputReference>()!;
        }

        [JsiiProperty(name: "permission", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserPermissionList\"}")]
        public virtual yandex.MdbMysqlCluster.MdbMysqlClusterUserPermissionList Permission
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.MdbMysqlClusterUserPermissionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationPluginInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthenticationPluginInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionLimitsInput", typeJson: "{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimits\"}", isOptional: true)]
        public virtual yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits? ConnectionLimitsInput
        {
            get => GetInstanceProperty<yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "globalPermissionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? GlobalPermissionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUserPermission\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PermissionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "authenticationPlugin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationPlugin
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "globalPermissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GlobalPermissions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.mdbMysqlCluster.MdbMysqlClusterUser\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.MdbMysqlCluster.IMdbMysqlClusterUser cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.MdbMysqlCluster.IMdbMysqlClusterUser).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
