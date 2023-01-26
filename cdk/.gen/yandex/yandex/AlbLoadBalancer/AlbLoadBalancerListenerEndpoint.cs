using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbLoadBalancer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albLoadBalancer.AlbLoadBalancerListenerEndpoint")]
    public class AlbLoadBalancerListenerEndpoint : yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpoint
    {
        private object _address;

        /// <summary>address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#address AlbLoadBalancer#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albLoadBalancer.AlbLoadBalancerListenerEndpointAddress\"},\"kind\":\"array\"}}]}}")]
        public object Address
        {
            get => _address;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddress[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddress).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbLoadBalancer.IAlbLoadBalancerListenerEndpointAddress).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _address = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_load_balancer#ports AlbLoadBalancer#ports}.</summary>
        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] Ports
        {
            get;
            set;
        }
    }
}
