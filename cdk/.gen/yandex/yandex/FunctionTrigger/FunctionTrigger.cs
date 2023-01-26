using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.FunctionTrigger
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger yandex_function_trigger}.</summary>
    [JsiiClass(nativeType: typeof(yandex.FunctionTrigger.FunctionTrigger), fullyQualifiedName: "yandex.functionTrigger.FunctionTrigger", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"yandex.functionTrigger.FunctionTriggerConfig\"}}]")]
    public class FunctionTrigger : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/function_trigger yandex_function_trigger} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public FunctionTrigger(Constructs.Construct scope, string id, yandex.FunctionTrigger.IFunctionTriggerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.FunctionTrigger.IFunctionTriggerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionTrigger(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionTrigger(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDlq", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.functionTrigger.FunctionTriggerDlq\"}}]")]
        public virtual void PutDlq(yandex.FunctionTrigger.IFunctionTriggerDlq @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.FunctionTrigger.IFunctionTriggerDlq)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFunction", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.functionTrigger.FunctionTriggerFunction\"}}]")]
        public virtual void PutFunction(yandex.FunctionTrigger.IFunctionTriggerFunction @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.FunctionTrigger.IFunctionTriggerFunction)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.functionTrigger.FunctionTriggerIot\"}}]")]
        public virtual void PutIot(yandex.FunctionTrigger.IFunctionTriggerIot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.FunctionTrigger.IFunctionTriggerIot)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogging", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.functionTrigger.FunctionTriggerLogging\"}}]")]
        public virtual void PutLogging(yandex.FunctionTrigger.IFunctionTriggerLogging @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.FunctionTrigger.IFunctionTriggerLogging)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLogGroup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.functionTrigger.FunctionTriggerLogGroup\"}}]")]
        public virtual void PutLogGroup(yandex.FunctionTrigger.IFunctionTriggerLogGroup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.FunctionTrigger.IFunctionTriggerLogGroup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMessageQueue", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.functionTrigger.FunctionTriggerMessageQueue\"}}]")]
        public virtual void PutMessageQueue(yandex.FunctionTrigger.IFunctionTriggerMessageQueue @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.FunctionTrigger.IFunctionTriggerMessageQueue)}, new object[]{@value});
        }

        [JsiiMethod(name: "putObjectStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.functionTrigger.FunctionTriggerObjectStorage\"}}]")]
        public virtual void PutObjectStorage(yandex.FunctionTrigger.IFunctionTriggerObjectStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.FunctionTrigger.IFunctionTriggerObjectStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.functionTrigger.FunctionTriggerTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.FunctionTrigger.IFunctionTriggerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.FunctionTrigger.IFunctionTriggerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimer", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.functionTrigger.FunctionTriggerTimer\"}}]")]
        public virtual void PutTimer(yandex.FunctionTrigger.IFunctionTriggerTimer @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.FunctionTrigger.IFunctionTriggerTimer)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDlq")]
        public virtual void ResetDlq()
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

        [JsiiMethod(name: "resetIot")]
        public virtual void ResetIot()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabels")]
        public virtual void ResetLabels()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogging")]
        public virtual void ResetLogging()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogGroup")]
        public virtual void ResetLogGroup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMessageQueue")]
        public virtual void ResetMessageQueue()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetObjectStorage")]
        public virtual void ResetObjectStorage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimer")]
        public virtual void ResetTimer()
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
        = GetStaticProperty<string>(typeof(yandex.FunctionTrigger.FunctionTrigger))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dlq", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerDlqOutputReference\"}")]
        public virtual yandex.FunctionTrigger.FunctionTriggerDlqOutputReference Dlq
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.FunctionTriggerDlqOutputReference>()!;
        }

        [JsiiProperty(name: "function", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerFunctionOutputReference\"}")]
        public virtual yandex.FunctionTrigger.FunctionTriggerFunctionOutputReference Function
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.FunctionTriggerFunctionOutputReference>()!;
        }

        [JsiiProperty(name: "iot", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerIotOutputReference\"}")]
        public virtual yandex.FunctionTrigger.FunctionTriggerIotOutputReference Iot
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.FunctionTriggerIotOutputReference>()!;
        }

        [JsiiProperty(name: "logging", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerLoggingOutputReference\"}")]
        public virtual yandex.FunctionTrigger.FunctionTriggerLoggingOutputReference Logging
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.FunctionTriggerLoggingOutputReference>()!;
        }

        [JsiiProperty(name: "logGroup", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerLogGroupOutputReference\"}")]
        public virtual yandex.FunctionTrigger.FunctionTriggerLogGroupOutputReference LogGroup
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.FunctionTriggerLogGroupOutputReference>()!;
        }

        [JsiiProperty(name: "messageQueue", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerMessageQueueOutputReference\"}")]
        public virtual yandex.FunctionTrigger.FunctionTriggerMessageQueueOutputReference MessageQueue
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.FunctionTriggerMessageQueueOutputReference>()!;
        }

        [JsiiProperty(name: "objectStorage", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerObjectStorageOutputReference\"}")]
        public virtual yandex.FunctionTrigger.FunctionTriggerObjectStorageOutputReference ObjectStorage
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.FunctionTriggerObjectStorageOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerTimeoutsOutputReference\"}")]
        public virtual yandex.FunctionTrigger.FunctionTriggerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.FunctionTriggerTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "timer", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerTimerOutputReference\"}")]
        public virtual yandex.FunctionTrigger.FunctionTriggerTimerOutputReference Timer
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.FunctionTriggerTimerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dlqInput", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerDlq\"}", isOptional: true)]
        public virtual yandex.FunctionTrigger.IFunctionTriggerDlq? DlqInput
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerDlq?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "folderIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FolderIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionInput", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerFunction\"}", isOptional: true)]
        public virtual yandex.FunctionTrigger.IFunctionTriggerFunction? FunctionInput
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerFunction?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iotInput", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerIot\"}", isOptional: true)]
        public virtual yandex.FunctionTrigger.IFunctionTriggerIot? IotInput
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerIot?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? LabelsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingInput", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerLogging\"}", isOptional: true)]
        public virtual yandex.FunctionTrigger.IFunctionTriggerLogging? LoggingInput
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerLogging?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logGroupInput", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerLogGroup\"}", isOptional: true)]
        public virtual yandex.FunctionTrigger.IFunctionTriggerLogGroup? LogGroupInput
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerLogGroup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "messageQueueInput", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerMessageQueue\"}", isOptional: true)]
        public virtual yandex.FunctionTrigger.IFunctionTriggerMessageQueue? MessageQueueInput
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerMessageQueue?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectStorageInput", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerObjectStorage\"}", isOptional: true)]
        public virtual yandex.FunctionTrigger.IFunctionTriggerObjectStorage? ObjectStorageInput
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerObjectStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.functionTrigger.FunctionTriggerTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timerInput", typeJson: "{\"fqn\":\"yandex.functionTrigger.FunctionTriggerTimer\"}", isOptional: true)]
        public virtual yandex.FunctionTrigger.IFunctionTriggerTimer? TimerInput
        {
            get => GetInstanceProperty<yandex.FunctionTrigger.IFunctionTriggerTimer?>();
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
