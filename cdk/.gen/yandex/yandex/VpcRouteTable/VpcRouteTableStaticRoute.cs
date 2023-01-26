using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.VpcRouteTable
{
    [JsiiByValue(fqn: "yandex.vpcRouteTable.VpcRouteTableStaticRoute")]
    public class VpcRouteTableStaticRoute : yandex.VpcRouteTable.IVpcRouteTableStaticRoute
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_route_table#destination_prefix VpcRouteTable#destination_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_route_table#gateway_id VpcRouteTable#gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/vpc_route_table#next_hop_address VpcRouteTable#next_hop_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nextHopAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NextHopAddress
        {
            get;
            set;
        }
    }
}
