using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    [JsiiClass(nativeType: typeof(yandex.AlbHttpRouter.AlbHttpRouterRouteOptionsOutputReference), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbHttpRouterRouteOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbHttpRouterRouteOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbHttpRouterRouteOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbHttpRouterRouteOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRbac", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbac\"}}]")]
        public virtual void PutRbac(yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbac @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbac)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRbac")]
        public virtual void ResetRbac()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "rbac", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacOutputReference\"}")]
        public virtual yandex.AlbHttpRouter.AlbHttpRouterRouteOptionsRbacOutputReference Rbac
        {
            get => GetInstanceProperty<yandex.AlbHttpRouter.AlbHttpRouterRouteOptionsRbacOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "rbacInput", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbac\"}", isOptional: true)]
        public virtual yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbac? RbacInput
        {
            get => GetInstanceProperty<yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbac?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptions\"}", isOptional: true)]
        public virtual yandex.AlbHttpRouter.IAlbHttpRouterRouteOptions? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbHttpRouter.IAlbHttpRouterRouteOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
