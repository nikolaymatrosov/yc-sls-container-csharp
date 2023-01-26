using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeSnapshotSchedule
{
    [JsiiByValue(fqn: "yandex.dataYandexComputeSnapshotSchedule.DataYandexComputeSnapshotScheduleSnapshotSpec")]
    public class DataYandexComputeSnapshotScheduleSnapshotSpec : yandex.DataYandexComputeSnapshotSchedule.IDataYandexComputeSnapshotScheduleSnapshotSpec
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#description DataYandexComputeSnapshotSchedule#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#labels DataYandexComputeSnapshotSchedule#labels}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get;
            set;
        }
    }
}
