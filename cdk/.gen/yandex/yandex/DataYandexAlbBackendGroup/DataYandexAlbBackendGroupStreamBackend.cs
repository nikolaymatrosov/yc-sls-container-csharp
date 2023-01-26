using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackend")]
    public class DataYandexAlbBackendGroupStreamBackend : yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackend
    {
        private object? _enableProxyProtocol;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#enable_proxy_protocol DataYandexAlbBackendGroup#enable_proxy_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableProxyProtocol", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? EnableProxyProtocol
        {
            get => _enableProxyProtocol;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableProxyProtocol = value;
            }
        }

        /// <summary>healthcheck block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#healthcheck DataYandexAlbBackendGroup#healthcheck}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "healthcheck", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendHealthcheck\"}", isOptional: true)]
        public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendHealthcheck? Healthcheck
        {
            get;
            set;
        }

        /// <summary>load_balancing_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#load_balancing_config DataYandexAlbBackendGroup#load_balancing_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loadBalancingConfig", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendLoadBalancingConfig\"}", isOptional: true)]
        public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendLoadBalancingConfig? LoadBalancingConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#port DataYandexAlbBackendGroup#port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }

        /// <summary>tls block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#tls DataYandexAlbBackendGroup#tls}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupStreamBackendTls\"}", isOptional: true)]
        public yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupStreamBackendTls? Tls
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#weight DataYandexAlbBackendGroup#weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}
