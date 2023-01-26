using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiClass(nativeType: typeof(yandex.AlbVirtualHost.AlbVirtualHostRouteGrpcRouteOutputReference), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AlbVirtualHostRouteGrpcRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AlbVirtualHostRouteGrpcRouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AlbVirtualHostRouteGrpcRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbVirtualHostRouteGrpcRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpcMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatch\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutGrpcMatch(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatch[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatch).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcMatch).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrpcRouteAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcRouteAction\"}}]")]
        public virtual void PutGrpcRouteAction(yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcRouteAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcRouteAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGrpcStatusResponseAction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction\"}}]")]
        public virtual void PutGrpcStatusResponseAction(yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrpcMatch")]
        public virtual void ResetGrpcMatch()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrpcRouteAction")]
        public virtual void ResetGrpcRouteAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGrpcStatusResponseAction")]
        public virtual void ResetGrpcStatusResponseAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grpcMatch", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatchList\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatchList GrpcMatch
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatchList>()!;
        }

        [JsiiProperty(name: "grpcRouteAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcRouteActionOutputReference\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcRouteActionOutputReference GrpcRouteAction
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcRouteActionOutputReference>()!;
        }

        [JsiiProperty(name: "grpcStatusResponseAction", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcStatusResponseActionOutputReference\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcStatusResponseActionOutputReference GrpcStatusResponseAction
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcStatusResponseActionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcMatchInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? GrpcMatchInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcRouteActionInput", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcRouteAction\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcRouteAction? GrpcRouteActionInput
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcRouteAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcStatusResponseActionInput", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction? GrpcStatusResponseActionInput
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRouteGrpcStatusResponseAction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRoute\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute? InternalValue
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
