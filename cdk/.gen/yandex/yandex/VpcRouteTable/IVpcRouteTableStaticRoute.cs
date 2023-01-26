using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.VpcRouteTable
{
    [JsiiInterface(nativeType: typeof(IVpcRouteTableStaticRoute), fullyQualifiedName: "yandex.vpcRouteTable.VpcRouteTableStaticRoute")]
    public interface IVpcRouteTableStaticRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_route_table#destination_prefix VpcRouteTable#destination_prefix}.</summary>
        [JsiiProperty(name: "destinationPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_route_table#gateway_id VpcRouteTable#gateway_id}.</summary>
        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GatewayId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_route_table#next_hop_address VpcRouteTable#next_hop_address}.</summary>
        [JsiiProperty(name: "nextHopAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NextHopAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpcRouteTableStaticRoute), fullyQualifiedName: "yandex.vpcRouteTable.VpcRouteTableStaticRoute")]
        internal sealed class _Proxy : DeputyBase, yandex.VpcRouteTable.IVpcRouteTableStaticRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_route_table#destination_prefix VpcRouteTable#destination_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_route_table#gateway_id VpcRouteTable#gateway_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GatewayId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_route_table#next_hop_address VpcRouteTable#next_hop_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nextHopAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NextHopAddress
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
