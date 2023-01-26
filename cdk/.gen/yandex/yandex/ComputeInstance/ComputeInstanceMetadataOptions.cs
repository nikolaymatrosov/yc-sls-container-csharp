using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    [JsiiByValue(fqn: "yandex.computeInstance.ComputeInstanceMetadataOptions")]
    public class ComputeInstanceMetadataOptions : yandex.ComputeInstance.IComputeInstanceMetadataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#aws_v1_http_endpoint ComputeInstance#aws_v1_http_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsV1HttpEndpoint", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AwsV1HttpEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#aws_v1_http_token ComputeInstance#aws_v1_http_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsV1HttpToken", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AwsV1HttpToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#gce_http_endpoint ComputeInstance#gce_http_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gceHttpEndpoint", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GceHttpEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#gce_http_token ComputeInstance#gce_http_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gceHttpToken", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GceHttpToken
        {
            get;
            set;
        }
    }
}
