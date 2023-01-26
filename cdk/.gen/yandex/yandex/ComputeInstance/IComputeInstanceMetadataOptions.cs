using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstance
{
    [JsiiInterface(nativeType: typeof(IComputeInstanceMetadataOptions), fullyQualifiedName: "yandex.computeInstance.ComputeInstanceMetadataOptions")]
    public interface IComputeInstanceMetadataOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#aws_v1_http_endpoint ComputeInstance#aws_v1_http_endpoint}.</summary>
        [JsiiProperty(name: "awsV1HttpEndpoint", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AwsV1HttpEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#aws_v1_http_token ComputeInstance#aws_v1_http_token}.</summary>
        [JsiiProperty(name: "awsV1HttpToken", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AwsV1HttpToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#gce_http_endpoint ComputeInstance#gce_http_endpoint}.</summary>
        [JsiiProperty(name: "gceHttpEndpoint", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GceHttpEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#gce_http_token ComputeInstance#gce_http_token}.</summary>
        [JsiiProperty(name: "gceHttpToken", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GceHttpToken
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IComputeInstanceMetadataOptions), fullyQualifiedName: "yandex.computeInstance.ComputeInstanceMetadataOptions")]
        internal sealed class _Proxy : DeputyBase, yandex.ComputeInstance.IComputeInstanceMetadataOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#aws_v1_http_endpoint ComputeInstance#aws_v1_http_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsV1HttpEndpoint", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AwsV1HttpEndpoint
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#aws_v1_http_token ComputeInstance#aws_v1_http_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsV1HttpToken", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AwsV1HttpToken
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#gce_http_endpoint ComputeInstance#gce_http_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gceHttpEndpoint", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GceHttpEndpoint
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance#gce_http_token ComputeInstance#gce_http_token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gceHttpToken", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GceHttpToken
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
