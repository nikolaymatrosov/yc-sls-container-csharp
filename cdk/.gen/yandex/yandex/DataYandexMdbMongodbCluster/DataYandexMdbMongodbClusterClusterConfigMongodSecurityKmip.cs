using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbMongodbCluster
{
    [JsiiByValue(fqn: "yandex.dataYandexMdbMongodbCluster.DataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip")]
    public class DataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip : yandex.DataYandexMdbMongodbCluster.IDataYandexMdbMongodbClusterClusterConfigMongodSecurityKmip
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#client_certificate DataYandexMdbMongodbCluster#client_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#key_identifier DataYandexMdbMongodbCluster#key_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#port DataYandexMdbMongodbCluster#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#server_ca DataYandexMdbMongodbCluster#server_ca}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverCa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerCa
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_mongodb_cluster#server_name DataYandexMdbMongodbCluster#server_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerName
        {
            get;
            set;
        }
    }
}
