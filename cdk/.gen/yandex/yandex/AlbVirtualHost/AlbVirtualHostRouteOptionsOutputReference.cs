using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiClass(nativeType: typeof(yandex.AlbVirtualHost.AlbVirtualHostRouteOptionsOutputReference), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbVirtualHostRouteOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbVirtualHostRouteOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbVirtualHostRouteOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbVirtualHostRouteOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRbac", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbac\"}}]")]
        public virtual void PutRbac(yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbac @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbac)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRbac")]
        public virtual void ResetRbac()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rbac", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbacOutputReference\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteOptionsRbacOutputReference Rbac
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteOptionsRbacOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rbacInput", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptionsRbac\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbac? RbacInput
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteOptionsRbac?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteOptions\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteOptions? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
