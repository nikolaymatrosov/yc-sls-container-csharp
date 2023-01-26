using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerLogOptionsDiscardRule")]
    public class AlbLoadBalancerLogOptionsDiscardRule : yandex.AlbLoadBalancer.IAlbLoadBalancerLogOptionsDiscardRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#discard_percent AlbLoadBalancer#discard_percent}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "discardPercent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DiscardPercent
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#grpc_codes AlbLoadBalancer#grpc_codes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "grpcCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GrpcCodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_code_intervals AlbLoadBalancer#http_code_intervals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpCodeIntervals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? HttpCodeIntervals
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#http_codes AlbLoadBalancer#http_codes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}", isOptional: true)]
        public double[]? HttpCodes
        {
            get;
            set;
        }
    }
}
