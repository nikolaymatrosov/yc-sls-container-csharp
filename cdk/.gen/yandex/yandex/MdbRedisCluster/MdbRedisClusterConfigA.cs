using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbRedisCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.mdbRedisCluster.MdbRedisClusterConfigA")]
    public class MdbRedisClusterConfigA : yandex.MdbRedisCluster.IMdbRedisClusterConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#password MdbRedisCluster#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#version MdbRedisCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public string Version
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#client_output_buffer_limit_normal MdbRedisCluster#client_output_buffer_limit_normal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientOutputBufferLimitNormal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientOutputBufferLimitNormal
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#client_output_buffer_limit_pubsub MdbRedisCluster#client_output_buffer_limit_pubsub}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientOutputBufferLimitPubsub", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClientOutputBufferLimitPubsub
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#databases MdbRedisCluster#databases}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "databases", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Databases
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#maxmemory_policy MdbRedisCluster#maxmemory_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaxmemoryPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#notify_keyspace_events MdbRedisCluster#notify_keyspace_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NotifyKeyspaceEvents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#slowlog_log_slower_than MdbRedisCluster#slowlog_log_slower_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "slowlogLogSlowerThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SlowlogLogSlowerThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#slowlog_max_len MdbRedisCluster#slowlog_max_len}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "slowlogMaxLen", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SlowlogMaxLen
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#timeout MdbRedisCluster#timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Timeout
        {
            get;
            set;
        }
    }
}
