using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbHttpRouter
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router yandex_alb_http_router}.</summary>
    [JsiiClass(nativeType: typeof(yandex.AlbHttpRouter.AlbHttpRouter), fullyQualifiedName: "yandex.albHttpRouter.AlbHttpRouter", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterConfig\"}}]")]
    public class AlbHttpRouter : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/alb_http_router yandex_alb_http_router} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public AlbHttpRouter(Constructs.Construct scope, string id, yandex.AlbHttpRouter.IAlbHttpRouterConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.AlbHttpRouter.IAlbHttpRouterConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbHttpRouter(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AlbHttpRouter(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRouteOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptions\"}}]")]
        public virtual void PutRouteOptions(yandex.AlbHttpRouter.IAlbHttpRouterRouteOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbHttpRouter.IAlbHttpRouterRouteOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.AlbHttpRouter.IAlbHttpRouterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.AlbHttpRouter.IAlbHttpRouterTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFolderId")]
        public virtual void ResetFolderId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
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

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(yandex.AlbHttpRouter.AlbHttpRouter))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routeOptions", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptionsOutputReference\"}")]
        public virtual yandex.AlbHttpRouter.AlbHttpRouterRouteOptionsOutputReference RouteOptions
        {
            get => GetInstanceProperty<yandex.AlbHttpRouter.AlbHttpRouterRouteOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterTimeoutsOutputReference\"}")]
        public virtual yandex.AlbHttpRouter.AlbHttpRouterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.AlbHttpRouter.AlbHttpRouterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "folderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FolderIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "routeOptionsInput", typeJson: "{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterRouteOptions\"}", isOptional: true)]
        public virtual yandex.AlbHttpRouter.IAlbHttpRouterRouteOptions? RouteOptionsInput
        {
            get => GetInstanceProperty<yandex.AlbHttpRouter.IAlbHttpRouterRouteOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.albHttpRouter.AlbHttpRouterTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "folderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FolderId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Labels
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
