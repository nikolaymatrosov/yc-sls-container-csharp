using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityOutputReference), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataYandexAlbBackendGroupSessionAffinityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataYandexAlbBackendGroupSessionAffinityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataYandexAlbBackendGroupSessionAffinityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexAlbBackendGroupSessionAffinityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConnection", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityConnection\"}}]")]
        public virtual void PutConnection(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityConnection @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityConnection)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCookie", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityCookie\"}}]")]
        public virtual void PutCookie(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityCookie @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityCookie)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityHeader\"}}]")]
        public virtual void PutHeader(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityHeader)}, new object[]{@value});
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

        [JsiiProperty(name: "connection", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityConnectionOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityConnectionOutputReference Connection
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityConnectionOutputReference>()!;
        }

        [JsiiProperty(name: "cookie", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityCookieOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityCookieOutputReference Cookie
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityCookieOutputReference>()!;
        }

        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityHeaderOutputReference\"}")]
        public virtual yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityHeaderOutputReference Header
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityHeaderOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityConnection\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityConnection? ConnectionInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityConnection?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cookieInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityCookie\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityCookie? CookieInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityCookie?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "headerInput", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinityHeader\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityHeader? HeaderInput
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinityHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupSessionAffinity\"}", isOptional: true)]
        public virtual yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinity? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupSessionAffinity?>();
            set => SetInstanceProperty(value);
        }
    }
}
