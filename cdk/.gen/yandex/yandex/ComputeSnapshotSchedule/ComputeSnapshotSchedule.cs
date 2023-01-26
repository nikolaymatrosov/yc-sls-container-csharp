using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeSnapshotSchedule
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/yandex/r/compute_snapshot_schedule yandex_compute_snapshot_schedule}.</summary>
    [JsiiClass(nativeType: typeof(yandex.ComputeSnapshotSchedule.ComputeSnapshotSchedule), fullyQualifiedName: "yandex.computeSnapshotSchedule.ComputeSnapshotSchedule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"yandex.computeSnapshotSchedule.ComputeSnapshotScheduleConfig\"}}]")]
    public class ComputeSnapshotSchedule : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/yandex/r/compute_snapshot_schedule yandex_compute_snapshot_schedule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ComputeSnapshotSchedule(Constructs.Construct scope, string id, yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleConfig? config = null): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleConfig? config = null)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeSnapshotSchedule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ComputeSnapshotSchedule(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSchedulePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeSnapshotSchedule.ComputeSnapshotScheduleSchedulePolicy\"}}]")]
        public virtual void PutSchedulePolicy(yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleSchedulePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleSchedulePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSnapshotSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeSnapshotSchedule.ComputeSnapshotScheduleSnapshotSpec\"}}]")]
        public virtual void PutSnapshotSpec(yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleSnapshotSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleSnapshotSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"yandex.computeSnapshotSchedule.ComputeSnapshotScheduleTimeouts\"}}]")]
        public virtual void PutTimeouts(yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDiskIds")]
        public virtual void ResetDiskIds()
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

        [JsiiMethod(name: "resetRetentionPeriod")]
        public virtual void ResetRetentionPeriod()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchedulePolicy")]
        public virtual void ResetSchedulePolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotCount")]
        public virtual void ResetSnapshotCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSnapshotSpec")]
        public virtual void ResetSnapshotSpec()
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
        = GetStaticProperty<string>(typeof(yandex.ComputeSnapshotSchedule.ComputeSnapshotSchedule))!;

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schedulePolicy", typeJson: "{\"fqn\":\"yandex.computeSnapshotSchedule.ComputeSnapshotScheduleSchedulePolicyOutputReference\"}")]
        public virtual yandex.ComputeSnapshotSchedule.ComputeSnapshotScheduleSchedulePolicyOutputReference SchedulePolicy
        {
            get => GetInstanceProperty<yandex.ComputeSnapshotSchedule.ComputeSnapshotScheduleSchedulePolicyOutputReference>()!;
        }

        [JsiiProperty(name: "snapshotSpec", typeJson: "{\"fqn\":\"yandex.computeSnapshotSchedule.ComputeSnapshotScheduleSnapshotSpecOutputReference\"}")]
        public virtual yandex.ComputeSnapshotSchedule.ComputeSnapshotScheduleSnapshotSpecOutputReference SnapshotSpec
        {
            get => GetInstanceProperty<yandex.ComputeSnapshotSchedule.ComputeSnapshotScheduleSnapshotSpecOutputReference>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"yandex.computeSnapshotSchedule.ComputeSnapshotScheduleTimeoutsOutputReference\"}")]
        public virtual yandex.ComputeSnapshotSchedule.ComputeSnapshotScheduleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<yandex.ComputeSnapshotSchedule.ComputeSnapshotScheduleTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "diskIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? DiskIdsInput
        {
            get => GetInstanceProperty<string[]?>();
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
        [JsiiProperty(name: "retentionPeriodInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RetentionPeriodInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schedulePolicyInput", typeJson: "{\"fqn\":\"yandex.computeSnapshotSchedule.ComputeSnapshotScheduleSchedulePolicy\"}", isOptional: true)]
        public virtual yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleSchedulePolicy? SchedulePolicyInput
        {
            get => GetInstanceProperty<yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleSchedulePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SnapshotCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "snapshotSpecInput", typeJson: "{\"fqn\":\"yandex.computeSnapshotSchedule.ComputeSnapshotScheduleSnapshotSpec\"}", isOptional: true)]
        public virtual yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleSnapshotSpec? SnapshotSpecInput
        {
            get => GetInstanceProperty<yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleSnapshotSpec?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"yandex.computeSnapshotSchedule.ComputeSnapshotScheduleTimeouts\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
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

        [JsiiProperty(name: "diskIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DiskIds
        {
            get => GetInstanceProperty<string[]>()!;
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

        [JsiiProperty(name: "retentionPeriod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RetentionPeriod
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "snapshotCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SnapshotCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
