using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IAlbBackendGroupGrpcBackend), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupGrpcBackend")]
    public interface IAlbBackendGroupGrpcBackend
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#name AlbBackendGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#target_group_ids AlbBackendGroup#target_group_ids}.</summary>
        [JsiiProperty(name: "targetGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TargetGroupIds
        {
            get;
        }

        /// <summary>healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#healthcheck AlbBackendGroup#healthcheck}
        /// </remarks>
        [JsiiProperty(name: "healthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheck? Healthcheck
        {
            get
            {
                return null;
            }
        }

        /// <summary>load_balancing_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#load_balancing_config AlbBackendGroup#load_balancing_config}
        /// </remarks>
        [JsiiProperty(name: "loadBalancingConfig", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendLoadBalancingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendLoadBalancingConfig? LoadBalancingConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#port AlbBackendGroup#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#tls AlbBackendGroup#tls}
        /// </remarks>
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendTls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTls? Tls
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#weight AlbBackendGroup#weight}.</summary>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Weight
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbBackendGroupGrpcBackend), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupGrpcBackend")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackend
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#name AlbBackendGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#target_group_ids AlbBackendGroup#target_group_ids}.</summary>
            [JsiiProperty(name: "targetGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TargetGroupIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>healthcheck block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#healthcheck AlbBackendGroup#healthcheck}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendHealthcheck\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheck? Healthcheck
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendHealthcheck?>();
            }

            /// <summary>load_balancing_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#load_balancing_config AlbBackendGroup#load_balancing_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancingConfig", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendLoadBalancingConfig\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendLoadBalancingConfig? LoadBalancingConfig
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendLoadBalancingConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#port AlbBackendGroup#port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Port
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>tls block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#tls AlbBackendGroup#tls}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupGrpcBackendTls\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTls? Tls
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupGrpcBackendTls?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#weight AlbBackendGroup#weight}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Weight
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
