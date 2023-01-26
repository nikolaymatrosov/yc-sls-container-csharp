using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiInterface(nativeType: typeof(IAlbLoadBalancerLogOptionsDiscardRule), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerLogOptionsDiscardRule")]
    public interface IAlbLoadBalancerLogOptionsDiscardRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#discard_percent AlbLoadBalancer#discard_percent}.</summary>
        [JsiiProperty(name: "discardPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DiscardPercent
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#grpc_codes AlbLoadBalancer#grpc_codes}.</summary>
        [JsiiProperty(name: "grpcCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GrpcCodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_code_intervals AlbLoadBalancer#http_code_intervals}.</summary>
        [JsiiProperty(name: "httpCodeIntervals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HttpCodeIntervals
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_codes AlbLoadBalancer#http_codes}.</summary>
        [JsiiProperty(name: "httpCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double[]? HttpCodes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbLoadBalancerLogOptionsDiscardRule), fullyQualifiedName: "yandex.albLoadBalancer.AlbLoadBalancerLogOptionsDiscardRule")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbLoadBalancer.IAlbLoadBalancerLogOptionsDiscardRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#discard_percent AlbLoadBalancer#discard_percent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "discardPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DiscardPercent
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#grpc_codes AlbLoadBalancer#grpc_codes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "grpcCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GrpcCodes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_code_intervals AlbLoadBalancer#http_code_intervals}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpCodeIntervals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HttpCodeIntervals
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_codes AlbLoadBalancer#http_codes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
            public double[]? HttpCodes
            {
                get => GetInstanceProperty<double[]?>();
            }
        }
    }
}
