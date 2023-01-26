using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMongodbCluster
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbMongodbClusterResources), fullyQualifiedName: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterResources")]
    public interface IDataYandexMdbMongodbClusterResources
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#disk_size DataYandexMdbMongodbCluster#disk_size}.</summary>
        [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiskSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#disk_type_id DataYandexMdbMongodbCluster#disk_type_id}.</summary>
        [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DiskTypeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#resource_preset_id DataYandexMdbMongodbCluster#resource_preset_id}.</summary>
        [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourcePresetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbMongodbClusterResources), fullyQualifiedName: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterResources")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#disk_size DataYandexMdbMongodbCluster#disk_size}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiskSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#disk_type_id DataYandexMdbMongodbCluster#disk_type_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "diskTypeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DiskTypeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#resource_preset_id DataYandexMdbMongodbCluster#resource_preset_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "resourcePresetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourcePresetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
