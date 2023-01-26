using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlUser
{
    [JsiiByValue(fqn: "yandex.mdbMysqlUser.MdbMysqlUserConnectionLimits")]
    public class MdbMysqlUserConnectionLimits : yandex.MdbMysqlUser.IMdbMysqlUserConnectionLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_connections_per_hour MdbMysqlUser#max_connections_per_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConnectionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConnectionsPerHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_questions_per_hour MdbMysqlUser#max_questions_per_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxQuestionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxQuestionsPerHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_updates_per_hour MdbMysqlUser#max_updates_per_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUpdatesPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUpdatesPerHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_user_connections MdbMysqlUser#max_user_connections}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUserConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUserConnections
        {
            get;
            set;
        }
    }
}
