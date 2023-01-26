using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMysqlUser
{
    [JsiiInterface(nativeType: typeof(IMdbMysqlUserConnectionLimits), fullyQualifiedName: "yandex.mdbMysqlUser.MdbMysqlUserConnectionLimits")]
    public interface IMdbMysqlUserConnectionLimits
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_connections_per_hour MdbMysqlUser#max_connections_per_hour}.</summary>
        [JsiiProperty(name: "maxConnectionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConnectionsPerHour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_questions_per_hour MdbMysqlUser#max_questions_per_hour}.</summary>
        [JsiiProperty(name: "maxQuestionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxQuestionsPerHour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_updates_per_hour MdbMysqlUser#max_updates_per_hour}.</summary>
        [JsiiProperty(name: "maxUpdatesPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUpdatesPerHour
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_user_connections MdbMysqlUser#max_user_connections}.</summary>
        [JsiiProperty(name: "maxUserConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxUserConnections
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbMysqlUserConnectionLimits), fullyQualifiedName: "yandex.mdbMysqlUser.MdbMysqlUserConnectionLimits")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbMysqlUser.IMdbMysqlUserConnectionLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_connections_per_hour MdbMysqlUser#max_connections_per_hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConnectionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConnectionsPerHour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_questions_per_hour MdbMysqlUser#max_questions_per_hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxQuestionsPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxQuestionsPerHour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_updates_per_hour MdbMysqlUser#max_updates_per_hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUpdatesPerHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUpdatesPerHour
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mysql_user#max_user_connections MdbMysqlUser#max_user_connections}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxUserConnections", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxUserConnections
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
