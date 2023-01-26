using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexFunctionTrigger
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/d/function_trigger yandex_function_trigger}.</summary>
    [JsiiClass(nativeType: typeof(yandex.DataYandexFunctionTrigger.DataYandexFunctionTrigger), fullyQualifiedName: "yandex.dataYandexFunctionTrigger.DataYandexFunctionTrigger", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.dataYandexFunctionTrigger.DataYandexFunctionTriggerConfig\"}}]")]
    public class DataYandexFunctionTrigger : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/d/function_trigger yandex_function_trigger} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataYandexFunctionTrigger(Constructs.Construct scope, string id, yandex.DataYandexFunctionTrigger.IDataYandexFunctionTriggerConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.DataYandexFunctionTrigger.IDataYandexFunctionTriggerConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexFunctionTrigger(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexFunctionTrigger(DeputyProps props): base(props)
        {
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

        [JsiiMethod(name: "resetName")]
        public virtual void ResetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTriggerId")]
        public virtual void ResetTriggerId()
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
        = GetStaticProperty<string>(typeof(yandex.DataYandexFunctionTrigger.DataYandexFunctionTrigger))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dlq", typeJson: "{\"fqn\":\"yandex.dataYandexFunctionTrigger.DataYandexFunctionTriggerDlqList\"}")]
        public virtual yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerDlqList Dlq
        {
            get => GetInstanceProperty<yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerDlqList>()!;
        }

        [JsiiProperty(name: "function", typeJson: "{\"fqn\":\"yandex.dataYandexFunctionTrigger.DataYandexFunctionTriggerFunctionList\"}")]
        public virtual yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerFunctionList Function
        {
            get => GetInstanceProperty<yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerFunctionList>()!;
        }

        [JsiiProperty(name: "iot", typeJson: "{\"fqn\":\"yandex.dataYandexFunctionTrigger.DataYandexFunctionTriggerIotList\"}")]
        public virtual yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerIotList Iot
        {
            get => GetInstanceProperty<yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerIotList>()!;
        }

        [JsiiProperty(name: "labels", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Labels
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"yandex.dataYandexFunctionTrigger.DataYandexFunctionTriggerLoggingList\"}")]
        public virtual yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerLoggingList Logging
        {
            get => GetInstanceProperty<yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerLoggingList>()!;
        }

        [JsiiProperty(name: "logGroup", typeJson: "{\"fqn\":\"yandex.dataYandexFunctionTrigger.DataYandexFunctionTriggerLogGroupList\"}")]
        public virtual yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerLogGroupList LogGroup
        {
            get => GetInstanceProperty<yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerLogGroupList>()!;
        }

        [JsiiProperty(name: "messageQueue", typeJson: "{\"fqn\":\"yandex.dataYandexFunctionTrigger.DataYandexFunctionTriggerMessageQueueList\"}")]
        public virtual yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerMessageQueueList MessageQueue
        {
            get => GetInstanceProperty<yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerMessageQueueList>()!;
        }

        [JsiiProperty(name: "objectStorage", typeJson: "{\"fqn\":\"yandex.dataYandexFunctionTrigger.DataYandexFunctionTriggerObjectStorageList\"}")]
        public virtual yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerObjectStorageList ObjectStorage
        {
            get => GetInstanceProperty<yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerObjectStorageList>()!;
        }

        [JsiiProperty(name: "timer", typeJson: "{\"fqn\":\"yandex.dataYandexFunctionTrigger.DataYandexFunctionTriggerTimerList\"}")]
        public virtual yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerTimerList Timer
        {
            get => GetInstanceProperty<yandex.DataYandexFunctionTrigger.DataYandexFunctionTriggerTimerList>()!;
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "triggerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TriggerIdInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "triggerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TriggerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
