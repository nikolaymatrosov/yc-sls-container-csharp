using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbBackendGroup
{
    [JsiiInterface(nativeType: typeof(IAlbBackendGroupSessionAffinityConnection), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupSessionAffinityConnection")]
    public interface IAlbBackendGroupSessionAffinityConnection
    {
        /// <summary>Use source IP address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#source_ip AlbBackendGroup#source_ip}
        /// </remarks>
        [JsiiProperty(name: "sourceIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SourceIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbBackendGroupSessionAffinityConnection), fullyQualifiedName: "yandex.albBackendGroup.AlbBackendGroupSessionAffinityConnection")]
        internal sealed class _Proxy : DeputyBase, yandex.AlbBackendGroup.IAlbBackendGroupSessionAffinityConnection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Use source IP address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_backend_group#source_ip AlbBackendGroup#source_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? SourceIp
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
