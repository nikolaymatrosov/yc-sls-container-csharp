using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.YdbDatabaseServerless
{
    [JsiiInterface(nativeType: typeof(IYdbDatabaseServerlessTimeouts), fullyQualifiedName: "yandex.ydbDatabaseServerless.YdbDatabaseServerlessTimeouts")]
    public interface IYdbDatabaseServerlessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_serverless#default YdbDatabaseServerless#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IYdbDatabaseServerlessTimeouts), fullyQualifiedName: "yandex.ydbDatabaseServerless.YdbDatabaseServerlessTimeouts")]
        internal sealed class _Proxy : DeputyBase, yandex.YdbDatabaseServerless.IYdbDatabaseServerlessTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/ydb_database_serverless#default YdbDatabaseServerless#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
