using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.LbTargetGroup
{
    [JsiiInterface(nativeType: typeof(ILbTargetGroupTarget), fullyQualifiedName: "yandex.lbTargetGroup.LbTargetGroupTarget")]
    public interface ILbTargetGroupTarget
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_target_group#address LbTargetGroup#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_target_group#subnet_id LbTargetGroup#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        string SubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbTargetGroupTarget), fullyQualifiedName: "yandex.lbTargetGroup.LbTargetGroupTarget")]
        internal sealed class _Proxy : DeputyBase, yandex.LbTargetGroup.ILbTargetGroupTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_target_group#address LbTargetGroup#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/lb_target_group#subnet_id LbTargetGroup#subnet_id}.</summary>
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string SubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
