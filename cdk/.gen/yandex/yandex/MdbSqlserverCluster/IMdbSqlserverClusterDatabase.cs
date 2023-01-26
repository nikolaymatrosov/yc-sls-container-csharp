using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbSqlserverCluster
{
    [JsiiInterface(nativeType: typeof(IMdbSqlserverClusterDatabase), fullyQualifiedName: "yandex.mdbSqlserverCluster.MdbSqlserverClusterDatabase")]
    public interface IMdbSqlserverClusterDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_sqlserver_cluster#name MdbSqlserverCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbSqlserverClusterDatabase), fullyQualifiedName: "yandex.mdbSqlserverCluster.MdbSqlserverClusterDatabase")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbSqlserverCluster.IMdbSqlserverClusterDatabase
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_sqlserver_cluster#name MdbSqlserverCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
