using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMongodbCluster
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbMongodbClusterMaintenanceWindow), fullyQualifiedName: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterMaintenanceWindow")]
    public interface IDataYandexMdbMongodbClusterMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#day DataYandexMdbMongodbCluster#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Day
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#hour DataYandexMdbMongodbCluster#hour}.</summary>
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Hour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#type DataYandexMdbMongodbCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbMongodbClusterMaintenanceWindow), fullyQualifiedName: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#day DataYandexMdbMongodbCluster#day}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Day
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#hour DataYandexMdbMongodbCluster#hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Hour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#type DataYandexMdbMongodbCluster#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
