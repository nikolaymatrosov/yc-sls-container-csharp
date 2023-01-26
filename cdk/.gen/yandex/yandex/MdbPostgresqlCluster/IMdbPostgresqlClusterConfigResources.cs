using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbPostgresqlCluster
{
    [JsiiInterface(nativeType: typeof(IMdbPostgresqlClusterConfigResources), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigResources")]
    public interface IMdbPostgresqlClusterConfigResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#disk_size MdbPostgresqlCluster#disk_size}.</summary>
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
        double DiskSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#resource_preset_id MdbPostgresqlCluster#resource_preset_id}.</summary>
        [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourcePresetId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#disk_type_id MdbPostgresqlCluster#disk_type_id}.</summary>
        [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiskTypeId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbPostgresqlClusterConfigResources), fullyQualifiedName: "yandex.mdbPostgresqlCluster.MdbPostgresqlClusterConfigResources")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbPostgresqlCluster.IMdbPostgresqlClusterConfigResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#disk_size MdbPostgresqlCluster#disk_size}.</summary>
            [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
            public double DiskSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#resource_preset_id MdbPostgresqlCluster#resource_preset_id}.</summary>
            [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourcePresetId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_postgresql_cluster#disk_type_id MdbPostgresqlCluster#disk_type_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiskTypeId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
