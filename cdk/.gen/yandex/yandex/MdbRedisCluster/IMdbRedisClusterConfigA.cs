using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbRedisCluster
{
    [JsiiInterface(nativeType: typeof(IMdbRedisClusterConfigA), fullyQualifiedName: "yandex.mdbRedisCluster.MdbRedisClusterConfigA")]
    public interface IMdbRedisClusterConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#password MdbRedisCluster#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#version MdbRedisCluster#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        string Version
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#client_output_buffer_limit_normal MdbRedisCluster#client_output_buffer_limit_normal}.</summary>
        [JsiiProperty(name: "clientOutputBufferLimitNormal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientOutputBufferLimitNormal
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#client_output_buffer_limit_pubsub MdbRedisCluster#client_output_buffer_limit_pubsub}.</summary>
        [JsiiProperty(name: "clientOutputBufferLimitPubsub", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ClientOutputBufferLimitPubsub
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#databases MdbRedisCluster#databases}.</summary>
        [JsiiProperty(name: "databases", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Databases
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#maxmemory_policy MdbRedisCluster#maxmemory_policy}.</summary>
        [JsiiProperty(name: "maxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaxmemoryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#notify_keyspace_events MdbRedisCluster#notify_keyspace_events}.</summary>
        [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NotifyKeyspaceEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#slowlog_log_slower_than MdbRedisCluster#slowlog_log_slower_than}.</summary>
        [JsiiProperty(name: "slowlogLogSlowerThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SlowlogLogSlowerThan
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#slowlog_max_len MdbRedisCluster#slowlog_max_len}.</summary>
        [JsiiProperty(name: "slowlogMaxLen", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SlowlogMaxLen
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#timeout MdbRedisCluster#timeout}.</summary>
        [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbRedisClusterConfigA), fullyQualifiedName: "yandex.mdbRedisCluster.MdbRedisClusterConfigA")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbRedisCluster.IMdbRedisClusterConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#password MdbRedisCluster#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#version MdbRedisCluster#version}.</summary>
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
            public string Version
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#client_output_buffer_limit_normal MdbRedisCluster#client_output_buffer_limit_normal}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientOutputBufferLimitNormal", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientOutputBufferLimitNormal
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#client_output_buffer_limit_pubsub MdbRedisCluster#client_output_buffer_limit_pubsub}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "clientOutputBufferLimitPubsub", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ClientOutputBufferLimitPubsub
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#databases MdbRedisCluster#databases}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "databases", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Databases
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#maxmemory_policy MdbRedisCluster#maxmemory_policy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxmemoryPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaxmemoryPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#notify_keyspace_events MdbRedisCluster#notify_keyspace_events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "notifyKeyspaceEvents", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NotifyKeyspaceEvents
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#slowlog_log_slower_than MdbRedisCluster#slowlog_log_slower_than}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "slowlogLogSlowerThan", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SlowlogLogSlowerThan
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#slowlog_max_len MdbRedisCluster#slowlog_max_len}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "slowlogMaxLen", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SlowlogMaxLen
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#timeout MdbRedisCluster#timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Timeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
