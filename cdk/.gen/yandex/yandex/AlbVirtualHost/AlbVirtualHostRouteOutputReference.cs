using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    [JsiiClass(nativeType: typeof(yandex.AlbVirtualHost.AlbVirtualHostRouteOutputReference), fullyQualifiedName: "yandex.albVirtualHost.AlbVirtualHostRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AlbVirtualHostRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public AlbVirtualHostRouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected AlbVirtualHostRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbVirtualHostRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpcRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRoute\"}}]")]
        public virtual void PutGrpcRoute(yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRoute\"}}]")]
        public virtual void PutHttpRoute(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRouteOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptions\"}}]")]
        public virtual void PutRouteOptions(yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrpcRoute")]
        public virtual void ResetGrpcRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpRoute")]
        public virtual void ResetHttpRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRouteOptions")]
        public virtual void ResetRouteOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRouteOutputReference\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteGrpcRouteOutputReference GrpcRoute
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteGrpcRouteOutputReference>()!;
        }

        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRouteOutputReference\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteOutputReference HttpRoute
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteHttpRouteOutputReference>()!;
        }

        [JsiiProperty(name: "routeOptions", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsOutputReference\"}")]
        public virtual yandex.AlbVirtualHost.AlbVirtualHostRouteRouteOptionsOutputReference RouteOptions
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.AlbVirtualHostRouteRouteOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcRouteInput", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteGrpcRoute\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute? GrpcRouteInput
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteGrpcRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRouteInput", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteHttpRoute\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute? HttpRouteInput
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteHttpRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeOptionsInput", typeJson: "{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptions\"}", isOptional: true)]
        public virtual yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptions? RouteOptionsInput
        {
            get => GetInstanceProperty<yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptions?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRoute\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case yandex.AlbVirtualHost.IAlbVirtualHostRoute cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(yandex.AlbVirtualHost.IAlbVirtualHostRoute).FullName}, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
