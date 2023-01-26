using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    [JsiiByValue(fqn: "yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimits")]
    public class MdbMysqlClusterUserConnectionLimits : yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_connections_per_hour MdbMysqlCluster#max_connections_per_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConnectionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConnectionsPerHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_questions_per_hour MdbMysqlCluster#max_questions_per_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxQuestionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxQuestionsPerHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_updates_per_hour MdbMysqlCluster#max_updates_per_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUpdatesPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUpdatesPerHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_user_connections MdbMysqlCluster#max_user_connections}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxUserConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxUserConnections
        {
            get;
            set;
        }
    }
}
