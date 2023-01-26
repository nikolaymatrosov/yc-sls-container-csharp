using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMysqlUser
{
    [JsiiInterface(nativeType: typeof(IDataYandexMdbMysqlUserPermission), fullyQualifiedName: "yandex.dataYandexMdbMysqlUser.DataYandexMdbMysqlUserPermission")]
    public interface IDataYandexMdbMysqlUserPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mysql_user#roles DataYandexMdbMysqlUser#roles}.</summary>
        [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Roles
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexMdbMysqlUserPermission), fullyQualifiedName: "yandex.dataYandexMdbMysqlUser.DataYandexMdbMysqlUserPermission")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexMdbMysqlUser.IDataYandexMdbMysqlUserPermission
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mysql_user#roles DataYandexMdbMysqlUser#roles}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Roles
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
