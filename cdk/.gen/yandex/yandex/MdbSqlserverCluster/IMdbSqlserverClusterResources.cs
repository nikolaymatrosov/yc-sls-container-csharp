using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbSqlserverCluster
{
    [JsiiInterface(nativeType: typeof(IMdbSqlserverClusterResources), fullyQualifiedName: "yandex.mdbSqlserverCluster.MdbSqlserverClusterResources")]
    public interface IMdbSqlserverClusterResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_sqlserver_cluster#disk_size MdbSqlserverCluster#disk_size}.</summary>
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
        double DiskSize
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_sqlserver_cluster#disk_type_id MdbSqlserverCluster#disk_type_id}.</summary>
        [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}")]
        string DiskTypeId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_sqlserver_cluster#resource_preset_id MdbSqlserverCluster#resource_preset_id}.</summary>
        [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}")]
        string ResourcePresetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbSqlserverClusterResources), fullyQualifiedName: "yandex.mdbSqlserverCluster.MdbSqlserverClusterResources")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbSqlserverCluster.IMdbSqlserverClusterResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_sqlserver_cluster#disk_size MdbSqlserverCluster#disk_size}.</summary>
            [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}")]
            public double DiskSize
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_sqlserver_cluster#disk_type_id MdbSqlserverCluster#disk_type_id}.</summary>
            [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}")]
            public string DiskTypeId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_sqlserver_cluster#resource_preset_id MdbSqlserverCluster#resource_preset_id}.</summary>
            [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourcePresetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
