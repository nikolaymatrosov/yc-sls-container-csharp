using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck")]
    public interface IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#service_name AlbBackendGroup#service_name}.</summary>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ServiceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbBackendGroup.IAlbBackendGroupHttpBackendHealthcheckGrpcHealthcheck
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#service_name AlbBackendGroup#service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ServiceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
