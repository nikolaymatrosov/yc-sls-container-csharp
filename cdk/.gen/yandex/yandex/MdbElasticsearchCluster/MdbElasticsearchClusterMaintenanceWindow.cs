using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbElasticsearchCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbElasticsearchCluster.MdbElasticsearchClusterMaintenanceWindow")]
    public class MdbElasticsearchClusterMaintenanceWindow : yandex.MdbElasticsearchCluster.IMdbElasticsearchClusterMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#type MdbElasticsearchCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#day MdbElasticsearchCluster#day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Day
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_elasticsearch_cluster#hour MdbElasticsearchCluster#hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hour
        {
            get;
            set;
        }
    }
}
