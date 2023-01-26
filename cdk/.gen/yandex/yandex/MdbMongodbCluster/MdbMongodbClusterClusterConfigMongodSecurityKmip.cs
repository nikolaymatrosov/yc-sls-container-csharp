using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbMongodbCluster
{
    [JsiiByValue(fqn: "yandex.mdbMongodbCluster.MdbMongodbClusterClusterConfigMongodSecurityKmip")]
    public class MdbMongodbClusterClusterConfigMongodSecurityKmip : yandex.MdbMongodbCluster.IMdbMongodbClusterClusterConfigMongodSecurityKmip
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#client_certificate MdbMongodbCluster#client_certificate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientCertificate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientCertificate
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#key_identifier MdbMongodbCluster#key_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#port MdbMongodbCluster#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#server_ca MdbMongodbCluster#server_ca}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverCa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerCa
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_mongodb_cluster#server_name MdbMongodbCluster#server_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerName
        {
            get;
            set;
        }
    }
}
