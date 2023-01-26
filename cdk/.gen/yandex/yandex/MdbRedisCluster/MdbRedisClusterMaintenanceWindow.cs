using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbRedisCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbRedisCluster.MdbRedisClusterMaintenanceWindow")]
    public class MdbRedisClusterMaintenanceWindow : yandex.MdbRedisCluster.IMdbRedisClusterMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#type MdbRedisCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#day MdbRedisCluster#day}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Day
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#hour MdbRedisCluster#hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Hour
        {
            get;
            set;
        }
    }
}
