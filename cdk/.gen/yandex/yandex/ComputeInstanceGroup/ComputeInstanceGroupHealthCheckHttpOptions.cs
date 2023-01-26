using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.ComputeInstanceGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.computeInstanceGroup.ComputeInstanceGroupHealthCheckHttpOptions")]
    public class ComputeInstanceGroupHealthCheckHttpOptions : yandex.ComputeInstanceGroup.IComputeInstanceGroupHealthCheckHttpOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#path ComputeInstanceGroup#path}.</summary>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/compute_instance_group#port ComputeInstanceGroup#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }
    }
}
