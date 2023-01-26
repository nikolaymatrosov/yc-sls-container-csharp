using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeSnapshotSchedule
{
    [JsiiByValue(fqn: "yandex.computeSnapshotSchedule.ComputeSnapshotScheduleSchedulePolicy")]
    public class ComputeSnapshotScheduleSchedulePolicy : yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleSchedulePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_snapshot_schedule#expression ComputeSnapshotSchedule#expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Expression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_snapshot_schedule#start_at ComputeSnapshotSchedule#start_at}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startAt", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartAt
        {
            get;
            set;
        }
    }
}
