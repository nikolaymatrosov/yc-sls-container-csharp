using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiByValue(fqn: "yandex.albBackendGroup.AlbBackendGroupStreamBackendLoadBalancingConfig")]
    public class AlbBackendGroupStreamBackendLoadBalancingConfig : yandex.AlbBackendGroup.IAlbBackendGroupStreamBackendLoadBalancingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#locality_aware_routing_percent AlbBackendGroup#locality_aware_routing_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "localityAwareRoutingPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? LocalityAwareRoutingPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#mode AlbBackendGroup#mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Mode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#panic_threshold AlbBackendGroup#panic_threshold}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "panicThreshold", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PanicThreshold
        {
            get;
            set;
        }

        private object? _strictLocality;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#strict_locality AlbBackendGroup#strict_locality}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "strictLocality", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? StrictLocality
        {
            get => _strictLocality;
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
                _strictLocality = value;
            }
        }
    }
}
