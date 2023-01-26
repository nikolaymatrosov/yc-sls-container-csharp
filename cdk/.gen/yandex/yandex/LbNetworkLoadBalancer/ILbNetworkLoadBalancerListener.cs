using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbNetworkLoadBalancer
{
    [JsiiInterface(nativeType: typeof(ILbNetworkLoadBalancerListener), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListener")]
    public interface ILbNetworkLoadBalancerListener
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#name LbNetworkLoadBalancer#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#port LbNetworkLoadBalancer#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>external_address_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#external_address_spec LbNetworkLoadBalancer#external_address_spec}
        /// </remarks>
        [JsiiProperty(name: "externalAddressSpec", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerExternalAddressSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerExternalAddressSpec? ExternalAddressSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>internal_address_spec block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#internal_address_spec LbNetworkLoadBalancer#internal_address_spec}
        /// </remarks>
        [JsiiProperty(name: "internalAddressSpec", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerInternalAddressSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerInternalAddressSpec? InternalAddressSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#protocol LbNetworkLoadBalancer#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#target_port LbNetworkLoadBalancer#target_port}.</summary>
        [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbNetworkLoadBalancerListener), fullyQualifiedName: "yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListener")]
        internal sealed class _Proxy : DeputyBase, yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListener
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#name LbNetworkLoadBalancer#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#port LbNetworkLoadBalancer#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>external_address_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#external_address_spec LbNetworkLoadBalancer#external_address_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalAddressSpec", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerExternalAddressSpec\"}", isOptional: true)]
            public yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerExternalAddressSpec? ExternalAddressSpec
            {
                get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerExternalAddressSpec?>();
            }

            /// <summary>internal_address_spec block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#internal_address_spec LbNetworkLoadBalancer#internal_address_spec}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "internalAddressSpec", typeJson: "{\"fqn\":\"yandex.lbNetworkLoadBalancer.LbNetworkLoadBalancerListenerInternalAddressSpec\"}", isOptional: true)]
            public yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerInternalAddressSpec? InternalAddressSpec
            {
                get => GetInstanceProperty<yandex.LbNetworkLoadBalancer.ILbNetworkLoadBalancerListenerInternalAddressSpec?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#protocol LbNetworkLoadBalancer#protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_network_load_balancer#target_port LbNetworkLoadBalancer#target_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
