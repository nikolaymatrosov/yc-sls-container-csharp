using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbTargetGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.lbTargetGroup.LbTargetGroupTarget")]
    public class LbTargetGroupTarget : yandex.LbTargetGroup.ILbTargetGroupTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_target_group#address LbTargetGroup#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_target_group#subnet_id LbTargetGroup#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string SubnetId
        {
            get;
            set;
        }
    }
}
