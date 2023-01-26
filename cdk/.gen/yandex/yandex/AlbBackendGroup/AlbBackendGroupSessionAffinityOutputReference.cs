using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.AlbBackendGroup.AlbBackendGroupSessionAffinityOutputReference), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupSessionAffinityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbBackendGroupSessionAffinityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbBackendGroupSessionAffinityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbBackendGroupSessionAffinityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbBackendGroupSessionAffinityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityConnection\"}}]")]
        public virtual void PutConnection(yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityConnection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityConnection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCookie", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityCookie\"}}]")]
        public virtual void PutCookie(yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityCookie @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityCookie)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityHeader\"}}]")]
        public virtual void PutHeader(yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConnection")]
        public virtual void ResetConnection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCookie")]
        public virtual void ResetCookie()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHeader")]
        public virtual void ResetHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityConnectionOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupSessionAffinityConnectionOutputReference Connection
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupSessionAffinityConnectionOutputReference>()!;
        }

        [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityCookieOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupSessionAffinityCookieOutputReference Cookie
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupSessionAffinityCookieOutputReference>()!;
        }

        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityHeaderOutputReference\"}")]
        public virtual yandex.AlbBackendGroup.AlbBackendGroupSessionAffinityHeaderOutputReference Header
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.AlbBackendGroupSessionAffinityHeaderOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityConnection\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityConnection? ConnectionInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityConnection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookieInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityCookie\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityCookie? CookieInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityCookie?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerInput", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinityHeader\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityHeader? HeaderInput
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupSessionAffinity\"}", isOptional: true)]
        public virtual yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinity? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinity?>();
            set => SetInstanceProperty(value);
        }
    }
}
