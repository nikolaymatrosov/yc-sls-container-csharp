using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterDatabase), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterDatabase")]
    public interface IMdbClickhouseClusterDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#name MdbClickhouseCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterDatabase), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterDatabase")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterDatabase
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#name MdbClickhouseCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
