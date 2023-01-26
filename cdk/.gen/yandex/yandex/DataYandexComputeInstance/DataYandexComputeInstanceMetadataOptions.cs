using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexComputeInstance
{
    [JsiiByValue(fqn: "yandex.dataYandexComputeInstance.DataYandexComputeInstanceMetadataOptions")]
    public class DataYandexComputeInstanceMetadataOptions : yandex.DataYandexComputeInstance.IDataYandexComputeInstanceMetadataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#aws_v1_http_endpoint DataYandexComputeInstance#aws_v1_http_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsV1HttpEndpoint", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AwsV1HttpEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#aws_v1_http_token DataYandexComputeInstance#aws_v1_http_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsV1HttpToken", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? AwsV1HttpToken
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#gce_http_endpoint DataYandexComputeInstance#gce_http_endpoint}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gceHttpEndpoint", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GceHttpEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/compute_instance#gce_http_token DataYandexComputeInstance#gce_http_token}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gceHttpToken", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GceHttpToken
        {
            get;
            set;
        }
    }
}
