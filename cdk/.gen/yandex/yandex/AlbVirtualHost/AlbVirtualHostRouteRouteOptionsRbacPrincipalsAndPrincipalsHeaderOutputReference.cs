using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiClass(nativeType: typeof(yandex.AlbVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putValue", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue\"}}]")]
        public virtual void PutValue(yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetValue")]
        public virtual void ResetValue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "value", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValueOutputReference\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValueOutputReference Value
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValueOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "valueInput", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue? ValueInput
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeaderValue?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipalsAndPrincipalsHeader?>();
            set => SetInstanceProperty(value);
        }
    }
}
