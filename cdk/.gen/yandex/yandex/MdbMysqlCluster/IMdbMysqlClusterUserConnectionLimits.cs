using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlCluster
{
    [JsiiInterface(nativeType: typeof(IMdbMysqlClusterUserConnectionLimits), fullyQualifiedName: "yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimits")]
    public interface IMdbMysqlClusterUserConnectionLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_connections_per_hour MdbMysqlCluster#max_connections_per_hour}.</summary>
        [JsiiProperty(name: "maxConnectionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConnectionsPerHour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_questions_per_hour MdbMysqlCluster#max_questions_per_hour}.</summary>
        [JsiiProperty(name: "maxQuestionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxQuestionsPerHour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_updates_per_hour MdbMysqlCluster#max_updates_per_hour}.</summary>
        [JsiiProperty(name: "maxUpdatesPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUpdatesPerHour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_user_connections MdbMysqlCluster#max_user_connections}.</summary>
        [JsiiProperty(name: "maxUserConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUserConnections
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbMysqlClusterUserConnectionLimits), fullyQualifiedName: "yandex.mdbMysqlCluster.MdbMysqlClusterUserConnectionLimits")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbMysqlCluster.IMdbMysqlClusterUserConnectionLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_connections_per_hour MdbMysqlCluster#max_connections_per_hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConnectionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConnectionsPerHour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_questions_per_hour MdbMysqlCluster#max_questions_per_hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxQuestionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxQuestionsPerHour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_updates_per_hour MdbMysqlCluster#max_updates_per_hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUpdatesPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUpdatesPerHour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_cluster#max_user_connections MdbMysqlCluster#max_user_connections}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUserConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUserConnections
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
