using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbClickhouseCluster
{
    [JsiiInterface(nativeType: typeof(IMdbClickhouseClusterCloudStorage), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterCloudStorage")]
    public interface IMdbClickhouseClusterCloudStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#enabled MdbClickhouseCluster#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbClickhouseClusterCloudStorage), fullyQualifiedName: "yandex.mdbClickhouseCluster.MdbClickhouseClusterCloudStorage")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbClickhouseCluster.IMdbClickhouseClusterCloudStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_clickhouse_cluster#enabled MdbClickhouseCluster#enabled}.</summary>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
