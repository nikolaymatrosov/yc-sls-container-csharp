using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeSnapshotSchedule
{
    [JsiiInterface(nativeType: typeof(IDataYandexComputeSnapshotScheduleSnapshotSpec), fullyQualifiedName: "yandex.dataYandexComputeSnapshotSchedule.DataYandexComputeSnapshotScheduleSnapshotSpec")]
    public interface IDataYandexComputeSnapshotScheduleSnapshotSpec
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#description DataYandexComputeSnapshotSchedule#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#labels DataYandexComputeSnapshotSchedule#labels}.</summary>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexComputeSnapshotScheduleSnapshotSpec), fullyQualifiedName: "yandex.dataYandexComputeSnapshotSchedule.DataYandexComputeSnapshotScheduleSnapshotSpec")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexComputeSnapshotSchedule.IDataYandexComputeSnapshotScheduleSnapshotSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#description DataYandexComputeSnapshotSchedule#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_snapshot_schedule#labels DataYandexComputeSnapshotSchedule#labels}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Labels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
