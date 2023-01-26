using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeSnapshotSchedule
{
    [JsiiByValue(fqn: "yandex.computeSnapshotSchedule.ComputeSnapshotScheduleTimeouts")]
    public class ComputeSnapshotScheduleTimeouts : yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_snapshot_schedule#create ComputeSnapshotSchedule#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_snapshot_schedule#delete ComputeSnapshotSchedule#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_snapshot_schedule#update ComputeSnapshotSchedule#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
