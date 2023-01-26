using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    [JsiiClass(nativeType: typeof(yandex.AlbHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putValue", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue\"}}]")]
        public virtual void PutValue(yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetValue")]
        public virtual void ResetValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValueOutputReference\"}")]
        public virtual yandex.AlbHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValueOutputReference Value
        {
            get => GetInstanceProperty<yandex.AlbHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValueOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueInput", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue\"}", isOptional: true)]
        public virtual yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue? ValueInput
        {
            get => GetInstanceProperty<yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader\"}", isOptional: true)]
        public virtual yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbHttpRouter.IAlbHttpRouterRouteOptionsRbacPrincipalsAndPrincipalsHeader?>();
            set => SetInstanceProperty(value);
        }
    }
}
