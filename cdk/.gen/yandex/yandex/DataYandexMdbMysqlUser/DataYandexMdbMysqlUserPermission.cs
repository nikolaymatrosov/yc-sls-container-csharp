using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMysqlUser
{
    [JsiiByValue(fqn: "yandex.dataYandexMdbMysqlUser.DataYandexMdbMysqlUserPermission")]
    public class DataYandexMdbMysqlUserPermission : yandex.DataYandexMdbMysqlUser.IDataYandexMdbMysqlUserPermission
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mysql_user#roles DataYandexMdbMysqlUser#roles}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roles", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Roles
        {
            get;
            set;
        }
    }
}
