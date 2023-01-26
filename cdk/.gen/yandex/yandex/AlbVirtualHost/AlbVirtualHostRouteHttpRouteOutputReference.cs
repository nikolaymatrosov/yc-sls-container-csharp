using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiClass(nativeType: typeof(yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteOutputReference), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbVirtualHostRouteHttpRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbVirtualHostRouteHttpRouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbVirtualHostRouteHttpRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbVirtualHostRouteHttpRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDirectResponseAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteDirectResponseAction\"}}]")]
        public virtual void PutDirectResponseAction(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteDirectResponseAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteDirectResponseAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatch\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutHttpMatch(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatch[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatch).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpMatch).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpRouteAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteAction\"}}]")]
        public virtual void PutHttpRouteAction(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpRouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpRouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRedirectAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteRedirectAction\"}}]")]
        public virtual void PutRedirectAction(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteRedirectAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteRedirectAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDirectResponseAction")]
        public virtual void ResetDirectResponseAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpMatch")]
        public virtual void ResetHttpMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpRouteAction")]
        public virtual void ResetHttpRouteAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRedirectAction")]
        public virtual void ResetRedirectAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "directResponseAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteDirectResponseActionOutputReference\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteDirectResponseActionOutputReference DirectResponseAction
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteDirectResponseActionOutputReference>()!;
        }

        [JsiiProperty(name: "httpMatch", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatchList\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatchList HttpMatch
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatchList>()!;
        }

        [JsiiProperty(name: "httpRouteAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteActionOutputReference\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteActionOutputReference HttpRouteAction
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "redirectAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteRedirectActionOutputReference\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteRedirectActionOutputReference RedirectAction
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteRedirectActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "directResponseActionInput", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteDirectResponseAction\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteDirectResponseAction? DirectResponseActionInput
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteDirectResponseAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpMatchInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? HttpMatchInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRouteActionInput", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteHttpRouteAction\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpRouteAction? HttpRouteActionInput
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteHttpRouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "redirectActionInput", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteRedirectAction\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteRedirectAction? RedirectActionInput
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRouteRedirectAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRoute\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
