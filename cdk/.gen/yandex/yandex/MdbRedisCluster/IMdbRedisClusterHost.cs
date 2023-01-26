using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.MdbRedisCluster
{
    [JsiiInterface(nativeType: typeof(IMdbRedisClusterHost), fullyQualifiedName: "yandex.mdbRedisCluster.MdbRedisClusterHost")]
    public interface IMdbRedisClusterHost
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#zone MdbRedisCluster#zone}.</summary>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        string Zone
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#assign_public_ip MdbRedisCluster#assign_public_ip}.</summary>
        [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AssignPublicIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#replica_priority MdbRedisCluster#replica_priority}.</summary>
        [JsiiProperty(name: "replicaPriority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReplicaPriority
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#shard_name MdbRedisCluster#shard_name}.</summary>
        [JsiiProperty(name: "shardName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ShardName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#subnet_id MdbRedisCluster#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMdbRedisClusterHost), fullyQualifiedName: "yandex.mdbRedisCluster.MdbRedisClusterHost")]
        internal sealed class _Proxy : DeputyBase, yandex.MdbRedisCluster.IMdbRedisClusterHost
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#zone MdbRedisCluster#zone}.</summary>
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
            public string Zone
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#assign_public_ip MdbRedisCluster#assign_public_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "assignPublicIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AssignPublicIp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#replica_priority MdbRedisCluster#replica_priority}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicaPriority", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReplicaPriority
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#shard_name MdbRedisCluster#shard_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shardName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ShardName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/mdb_redis_cluster#subnet_id MdbRedisCluster#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
