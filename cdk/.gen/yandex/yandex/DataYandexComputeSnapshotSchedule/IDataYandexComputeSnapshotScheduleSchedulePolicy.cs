using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeSnapshotSchedule
{
    [JsiiInterface(nativeType: typeof(IDataYandexComputeSnapshotScheduleSchedulePolicy), fullyQualifiedName: "yandex.dataYandexComputeSnapshotSchedule.DataYandexComputeSnapshotScheduleSchedulePolicy")]
    public interface IDataYandexComputeSnapshotScheduleSchedulePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#expression DataYandexComputeSnapshotSchedule#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Expression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#start_at DataYandexComputeSnapshotSchedule#start_at}.</summary>
        [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartAt
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexComputeSnapshotScheduleSchedulePolicy), fullyQualifiedName: "yandex.dataYandexComputeSnapshotSchedule.DataYandexComputeSnapshotScheduleSchedulePolicy")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexComputeSnapshotSchedule.IDataYandexComputeSnapshotScheduleSchedulePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#expression DataYandexComputeSnapshotSchedule#expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Expression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#start_at DataYandexComputeSnapshotSchedule#start_at}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartAt
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
