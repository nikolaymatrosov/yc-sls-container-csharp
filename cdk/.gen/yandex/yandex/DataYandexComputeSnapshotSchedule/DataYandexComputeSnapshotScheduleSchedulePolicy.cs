using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeSnapshotSchedule
{
    [JsiiByValue(fqn: "yandex.dataYandexComputeSnapshotSchedule.DataYandexComputeSnapshotScheduleSchedulePolicy")]
    public class DataYandexComputeSnapshotScheduleSchedulePolicy : yandex.DataYandexComputeSnapshotSchedule.IDataYandexComputeSnapshotScheduleSchedulePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#expression DataYandexComputeSnapshotSchedule#expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#start_at DataYandexComputeSnapshotSchedule#start_at}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartAt
        {
            get;
            set;
        }
    }
}
