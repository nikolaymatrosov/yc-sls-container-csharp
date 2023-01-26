using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexAlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IDataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig")]
    public interface IDataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#locality_aware_routing_percent DataYandexAlbBackendGroup#locality_aware_routing_percent}.</summary>
        [JsiiProperty(name: "localityAwareRoutingPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LocalityAwareRoutingPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#mode DataYandexAlbBackendGroup#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#panic_threshold DataYandexAlbBackendGroup#panic_threshold}.</summary>
        [JsiiProperty(name: "panicThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? PanicThreshold
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#strict_locality DataYandexAlbBackendGroup#strict_locality}.</summary>
        [JsiiProperty(name: "strictLocality", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StrictLocality
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig), fullyQualifiedName: "yandex.dataYandexAlbBackendGroup.DataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig")]
        internal sealed class _Proxy : DeputyBase, yandex.DataYandexAlbBackendGroup.IDataYandexAlbBackendGroupGrpcBackendLoadBalancingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#locality_aware_routing_percent DataYandexAlbBackendGroup#locality_aware_routing_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "localityAwareRoutingPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LocalityAwareRoutingPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#mode DataYandexAlbBackendGroup#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#panic_threshold DataYandexAlbBackendGroup#panic_threshold}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "panicThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? PanicThreshold
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/alb_backend_group#strict_locality DataYandexAlbBackendGroup#strict_locality}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "strictLocality", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? StrictLocality
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
