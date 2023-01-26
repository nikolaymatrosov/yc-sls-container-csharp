using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IAlbBackendGroupStreamBackend), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupStreamBackend")]
    public interface IAlbBackendGroupStreamBackend
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

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#enable_proxy_protocol AlbBackendGroup#enable_proxy_protocol}.</summary>
        [JsiiProperty(name: "enableProxyProtocol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableProxyProtocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#healthcheck AlbBackendGroup#healthcheck}
        /// </remarks>
        [JsiiProperty(name: "healthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendHealthcheck\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendHealthcheck? Healthcheck
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
        [JsiiProperty(name: "loadBalancingConfig", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendLoadBalancingConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendLoadBalancingConfig? LoadBalancingConfig
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
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendTls\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendTls? Tls
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

        [JsiiTypeProxy(nativeType: typeof(IAlbBackendGroupStreamBackend), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupStreamBackend")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbBackendGroup.IAlbBackendGroupStreamBackend
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

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#enable_proxy_protocol AlbBackendGroup#enable_proxy_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableProxyProtocol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableProxyProtocol
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>healthcheck block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#healthcheck AlbBackendGroup#healthcheck}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "healthcheck", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendHealthcheck\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendHealthcheck? Healthcheck
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendHealthcheck?>();
            }

            /// <summary>load_balancing_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#load_balancing_config AlbBackendGroup#load_balancing_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancingConfig", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendLoadBalancingConfig\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendLoadBalancingConfig? LoadBalancingConfig
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendLoadBalancingConfig?>();
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
            [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.albBackendGroup.AlbBackendGroupStreamBackendTls\"}", isOptional: true)]
            public yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendTls? Tls
            {
                get => GetInstanceProperty<yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendTls?>();
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
