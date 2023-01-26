using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeSnapshotSchedule
{
    [JsiiByValue(fqn: "yandex.computeSnapshotSchedule.ComputeSnapshotScheduleSnapshotSpec")]
    public class ComputeSnapshotScheduleSnapshotSpec : yandex.ComputeSnapshotSchedule.IComputeSnapshotScheduleSnapshotSpec
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_snapshot_schedule#description ComputeSnapshotSchedule#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_snapshot_schedule#labels ComputeSnapshotSchedule#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get;
            set;
        }
    }
}
