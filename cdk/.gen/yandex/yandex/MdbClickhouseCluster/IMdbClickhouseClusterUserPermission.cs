using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterUserPermission), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterUserPermission")]
    public interface IMdbClickhouseClusterUserPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#database_name MdbClickhouseCluster#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        string DatabaseName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterUserPermission), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterUserPermission")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterUserPermission
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#database_name MdbClickhouseCluster#database_name}.</summary>
            [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
            public string DatabaseName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
